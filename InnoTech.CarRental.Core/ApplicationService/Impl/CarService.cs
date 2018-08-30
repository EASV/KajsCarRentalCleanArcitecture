using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InnoTech.CarRental.Core.DomainService;
using InnoTech.Core.Entities;

namespace InnoTech.CarRental.Core.ApplicationService.Impl
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository; 
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public Car GetCarInstance()
        {
            return new Car();
        }

        public List<Car> GetCars()
        {
            return _carRepository.ReadCars().ToList();
        }

        public Car AddCar(Car car)
        {
            if (string.IsNullOrEmpty(car.Color))
            {
                throw new InvalidOperationException("Car needs a Color");
            }
            return _carRepository.CreateCar(car);
        }

        public List<Car> GetCarsByModel()
        {
            return _carRepository.ReadCars()
                .Where(car => car.Model.Equals("Ford"))
                .ToList();
        }
    }
}
