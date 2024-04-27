using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.CarDescriptionInterfaces
{
    public interface ICarDescriptionRepository
    {
        Task<CarDescripotion> GetCarDescription(int carId);
    }
}
