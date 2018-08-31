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
        private readonly ICarMakeRepository _carMakeRepository;

        public CarService(ICarRepository carRepository,
            ICarMakeRepository carMakeRepository)
        {
            _carRepository = carRepository;
            _carMakeRepository = carMakeRepository;
        }

        public Car GetCarInstance()
        {
            return new Car();
        }

        public List<Car> GetCars()
        {
            var listCars = _carRepository.ReadCars().ToList();
            foreach (var car in listCars)
            {
                car.Make = _carMakeRepository.GetCarMakeById(car.Make.Id);
            }
            return listCars;
        }

        public Car AddCar(Car car)
        {
            if (string.IsNullOrEmpty(car.Color))
            {
                throw new InvalidOperationException("Car needs a Color");
            }
            return _carRepository.CreateCar(car);
        }

        public void DeleteCar(int id)
        {
            if (id < 1)
            {
                throw new InvalidOperationException("Car Id needs to be larger then 0");
            }
            _carRepository.DeleteCar(id);
        }

        public List<Car> Get3CheapestCars()
        {
            return _carRepository.ReadCars()
                .OrderBy(car => car.Price).Take(3)
                .ToList();
        }

        public List<Car> GetCarsByModel()
        {
            return _carRepository.ReadCars()
                .Where(car => car.Model.Equals("Ford"))
                .ToList();
        }
    }
}
