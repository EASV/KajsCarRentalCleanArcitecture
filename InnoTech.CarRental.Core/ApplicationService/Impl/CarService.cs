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

        public List<Car> GetCars()
        {
            return _carRepository.ReadCars().ToList();
        }
    }
}
