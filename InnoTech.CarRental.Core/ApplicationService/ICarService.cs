﻿using System;
using System.Collections.Generic;
using System.Text;
using InnoTech.Core.Entities;

namespace InnoTech.CarRental.Core.ApplicationService
{
    public interface ICarService
    {
        Car GetCarInstance();
        
        List<Car> GetCars();

        Car GetById(int id);

        Car AddCar(Car car);

        void DeleteCar(int id);

        List<Car> Get3CheapestCars();
    }
}
