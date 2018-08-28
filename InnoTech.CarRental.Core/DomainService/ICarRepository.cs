using System;
using System.Collections.Generic;
using System.Text;
using InnoTech.Core.Entities;

namespace InnoTech.CarRental.Core.DomainService
{
    public interface ICarRepository
    {
        IEnumerable<Car> ReadCars();
    }
}
