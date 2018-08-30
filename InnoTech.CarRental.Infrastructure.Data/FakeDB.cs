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

        public static void InitData() {
            var car1 = new Car()
            {
                Id = CarId++,
                Color = "Blue",
                Make = "Fiat",
                Model = "Fiesta",
                Price = 20000
            };
            var car2 = new Car()
            {
                Id = CarId++,
                Color = "Green",
                Make = "Volvo4",
                Model = "Upsa",
                Price = 50000
            };
            
            var car3 = new Car()
            {
                Id = CarId++,
                Color = "Green",
                Make = "Volvo3",
                Model = "Upsa",
                Price = 10000000
            };
            var car4 = new Car()
            {
                Id = CarId++,
                Color = "Green",
                Make = "Volvo2",
                Model = "Upsa",
                Price = 209932
            };
            var car5 = new Car()
            {
                Id = CarId++,
                Color = "Green",
                Make = "Volvo1",
                Model = "Upsa",
                Price = 550000
            };
            Cars = new List<Car> { car1, car2, car3, car4, car5 };
        }
    }
}
