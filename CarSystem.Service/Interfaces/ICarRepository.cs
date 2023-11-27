using CarSystem.Domain.Entities;

namespace CarSystem.Service.Interfaces
{
    public interface ICarRepository
    {
        ValueTask CreateAsync(CarModel model);
        ValueTask DeleteAsync(int CarId);
        ValueTask<IEnumerable<CarModel>> GetAllAsync();
    }
}
