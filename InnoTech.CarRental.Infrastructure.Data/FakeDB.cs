using InnoTech.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InnoTech.CarRental.Infrastructure.Data
{
    public static class FakeDB
    {
        public static int CarId = 1;
        public static IEnumerable<Car> Cars;

        public static int CarModelId = 1;
        public static IEnumerable<CarMake> CarMakes;

        public static void InitData() {
            var fiat = new CarMake()
            {
                Id = CarModelId++,
                Name = "Fiat"
            };
            var toyota = new CarMake()
            {
                Id = CarModelId++,
                Name = "Fluerenciance"
            };
            
            
            CarMakes = new List<CarMake> { fiat, toyota };
            
            var car1 = new Car()
            {
                Id = CarId++,
                Color = "Blue",
                Model = "Uno",
                Make = new CarMake(){Id = 1},
                Price = 20000
            };
            var car2 = new Car()
            {
                Id = CarId++,
                Color = "Green",
                Model = "Punto",
                Make = new CarMake(){Id = 1},
                Price = 50000
            };
            
            var car3 = new Car()
            {
                Id = CarId++,
                Color = "Green",
                Model = "Corolla",
                Make = new CarMake(){Id = 2},
                Price = 10000000
            };
            var car4 = new Car()
            {
                Id = CarId++,
                Color = "Green",
                Model = "Cyvic",
                Make = new CarMake(){Id = 2},
                Price = 209932
            };
            var car5 = new Car()
            {
                Id = CarId++,
                Color = "Green",
                Model = "Volvo1",
                Make = new CarMake(){Id = 1},
                Price = 550000
            };
            Cars = new List<Car> { car1, car2, car3, car4, car5 };
        }
    }
}
