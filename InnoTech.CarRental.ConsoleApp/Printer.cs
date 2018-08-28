using System;
using System.Collections.Generic;
using System.Text;
using InnoTech.CarRental.Core.ApplicationService;

namespace InnoTech.CarRental.ConsoleApp
{
    public class Printer
    {
        readonly ICarService _carService;
        public Printer(ICarService carService)
        {
            _carService = carService;
            ShowAllCars();
        }

        private void ShowAllCars()
        {
            var listOfCars = _carService.GetCars();
            foreach (var car in listOfCars)
            {
                Console.WriteLine("Id: " + car.Id + " Color: " + car.Color);
            }
        }
    }
}
