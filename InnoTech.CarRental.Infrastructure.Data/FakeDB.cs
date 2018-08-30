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
                Model = "Fiesta"
            };
            var car2 = new Car()
            {
                Id = CarId++,
                Color = "Green",
                Make = "Volvo",
                Model = "Upsa"
            };
            Cars = new List<Car> { car1, car2 };
        }
    }
}
