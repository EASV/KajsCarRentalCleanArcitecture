using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InnoTech.CarRental.Core.DomainService;
using InnoTech.Core.Entities;

namespace InnoTech.CarRental.Infrastructure.Data
{
    public class CarRepository: ICarRepository
    {
        public IEnumerable<Car> ReadCars()
        {
            return FakeDB.Cars;
        }

        public Car CreateCar(Car car)
        {
            car.Id = FakeDB.CarId++;
            var cars = FakeDB.Cars.ToList();
            cars.Add(car);
            FakeDB.Cars = cars;
            return car;
        }

        public void DeleteCar(int id)
        {
            var cars = FakeDB.Cars.ToList();
            var carToDelete = cars.FirstOrDefault(car => car.Id == id);
            cars.Remove(carToDelete);
            FakeDB.Cars = cars;
            
            //ctx.Cars.Delete(id)
        }
    }
}
