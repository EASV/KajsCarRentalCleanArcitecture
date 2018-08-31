using InnoTech.Core.Entities;

namespace InnoTech.CarRental.Core.DomainService
{
    public interface ICarMakeRepository
    {
        CarMake GetCarMakeById(int id);
    }
}