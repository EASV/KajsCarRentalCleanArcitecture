using System;
using System.Collections.Generic;
using System.Text;
using InnoTech.CarRental.Core.ApplicationService;
using InnoTech.Core.Entities;

namespace InnoTech.CarRental.ConsoleApp
{
    public class Printer
    {
        readonly ICarService _carService;
        public Printer(ICarService carService)
        {
            _carService = carService;
            StartUI();

        }
        
        void StartUI()
        {
            string[] menuItems = {
                "List All Cars",
                "Add Car",
                "Delete Car",
                "Edit Car",
                "3 Cheapest Cars",
                "Exit"
            };

            var selection = ShowMenu(menuItems);

            while (selection != 6)
            {
                switch (selection)
                {
                    case 1:
                        ShowAllCars();
                        break;
                    case 2:
                        AddCar();
                        break;
                    case 3:
                        DeleteCar();
                        break;
                    case 4:
                        Console.WriteLine("Update Car");
                        break;
                    case 5:
                        ShowCheapestCars();
                        break;
                    default:
                        break;
                }
                selection = ShowMenu(menuItems);
            }
            Console.WriteLine("Bye bye!");

            Console.ReadLine();
        }

        private void ShowCheapestCars()
        {
            var list = _carService.Get3CheapestCars();
            foreach (var car in list)
            {
                Console.WriteLine("Model: {0} Price: {1:N}",car.Make.Name, car.Price);
            }
        }

        private void DeleteCar()
        {
            int id;
            while (!int.TryParse(Console.ReadLine(), out id)
                   || id < 1)
            {
                Console.WriteLine("Please select a number above 0");
            }
            _carService.DeleteCar(id);
            Console.WriteLine("Car with id {0} Deleted", id);
        }

        private void AddCar()
        {
            var car = _carService.GetCarInstance();
            Console.WriteLine("Type Car Color:");
            car.Color = Console.ReadLine();
            Console.WriteLine("Type Car Make:");
            int carId;
            while (!int.TryParse(Console.ReadLine(), out carId))
            {
                Console.WriteLine("Write a Id for the Car Make");
            }

            car.Make = new CarMake() {Id = carId};
            
            Console.WriteLine("Type Car Model:");
            car.Model = Console.ReadLine();
            Console.WriteLine("Type Car Price:");
            double price;
            while (!double.TryParse(Console.ReadLine(), out price)
                   || price > 5000000
                   || price < 10000)
            {
                Console.WriteLine("Please select a number between 10.000 - 5.000.000");
            }

            car.Price = price;
            var carAdded = _carService.AddCar(car);
            if (carAdded.Id > 0)
            {
                Console.WriteLine("Car Added");
            }
        }

        int ShowMenu(string[] menuItems)
        {
            Console.WriteLine("Select What you want to do:\n");

            for (var i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"{(i + 1)}: {menuItems[i]}");
            }

            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)
                   || selection < 1
                   || selection > 5)
            {
                Console.WriteLine("Please select a number between 1-5");
            }

            return selection;
        }

        private void ShowAllCars()
        {
            var listOfCars = _carService.GetCars();
            foreach (var car in listOfCars)
            {
                Console.WriteLine("Id: {0}\nColor: {1}\nMake: {2}\nModel: {3}\nPrice: {4:N}\n", 
                    car.Id, car.Color, car.Make.Name, car.Model, car.Price);
            }
        }
    }
}
