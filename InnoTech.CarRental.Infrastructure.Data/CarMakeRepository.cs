using System.Linq;
using InnoTech.CarRental.Core.DomainService;
using InnoTech.Core.Entities;

namespace InnoTech.CarRental.Infrastructure.Data
{
    public class CarMakeRepository : ICarMakeRepository
    {
        public CarMake GetCarMakeById(int id)
        {
            return FakeDB.CarMakes
                .FirstOrDefault(car => car.Id == id);
        }
    }
}