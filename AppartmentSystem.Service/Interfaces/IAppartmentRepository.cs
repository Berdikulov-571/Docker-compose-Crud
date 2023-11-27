using AppartmentSystem.Domain.Entities;

namespace AppartmentSystem.Service.Interfaces
{
    public interface IAppartmentRepository
    {
        ValueTask CreateAsync(AppartmentModel model);
        ValueTask DeleteAsync(int appartmentId);
        ValueTask<IEnumerable<AppartmentModel>> GetAllAsync();
    }
}