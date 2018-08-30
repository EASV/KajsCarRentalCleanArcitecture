using System.Collections.Generic;
using System.IO;
using System.Linq;
using InnoTech.CarRental.Core.DomainService;
using InnoTech.Core.Entities;
using Newtonsoft.Json;

namespace InnoTech.CarRental.Infrastructure.Data
{
    public class CarFileRepository: ICarRepository
    {
        public IEnumerable<Car> ReadCars()
        {
            return JsonConvert.DeserializeObject<IEnumerable<Car>>(File.ReadAllText(@"./cars.json"));
        }

        public Car CreateCar(Car car)
        {
            var cars = JsonConvert.DeserializeObject<IEnumerable<Car>>(File.ReadAllText(@"./cars.json"));
            car.Id = cars.Max(foundCar => foundCar.Id);
            (cars as List<Car>).Add(car);
            SaveCars(cars);
            return car;
        }

        public void DeleteCar(int id)
        {
            throw new System.NotImplementedException();
        }

        private void SaveCars(IEnumerable<Car> cars)
        {
            var json = JsonConvert.SerializeObject(cars);
            //write string to file
            File.WriteAllText(@"./cars.json", json);
        }
    }
}