using SchoolSystem.Domain.Entities;

namespace SchoolSystem.Service.Interfaces
{
    public interface ITeacherRepository
    {
        ValueTask CreateAsync(Teacher teacher);
        ValueTask DeleteAsync(int teacherId);
        ValueTask<IEnumerable<Teacher>> GetAllAsync();
    }
}
