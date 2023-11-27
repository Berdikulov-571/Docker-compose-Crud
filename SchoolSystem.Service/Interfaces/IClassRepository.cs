using SchoolSystem.Domain.Entities;

namespace SchoolSystem.Service.Interfaces
{
    public interface IClassRepository
    {
        ValueTask CreateAsync(Class model);
        ValueTask DeleteAsync(int classId);
        ValueTask<IEnumerable<Class>> GetAllAsync();
    }
}
