using System;
using System.Collections.Generic;
using System.Text;
using InnoTech.Core.Entities;

namespace InnoTech.CarRental.Core.ApplicationService
{
    public interface ICarService
    {
        Car GetCarInstance();
        
        List<Car> GetCars();

        Car AddCar(Car car);
    }
}
