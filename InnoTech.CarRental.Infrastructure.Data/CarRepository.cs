using System;
using System.Collections.Generic;
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
    }
}
