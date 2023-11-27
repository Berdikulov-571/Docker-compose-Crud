using AppartmentSystem.DataAccess.DataContexts;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Domain.Entities;
using SchoolSystem.Service.Interfaces;

namespace SchoolSystem.Service.Services
{
    public class TeacherService : ITeacherRepository
    {
        private readonly ApplicationDbContext _context;

        public TeacherService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async ValueTask CreateAsync(Teacher teacher)
        {
            await _context.Teachers.AddAsync(teacher);
            await _context.SaveChangesAsync();
        }

        public async ValueTask DeleteAsync(int teacherId)
        {
            Teacher teacher = await _context.Teachers.FirstOrDefaultAsync(x => x.TeacherId == teacherId);

            if (teacher != null)
            {
                _context.Teachers.Remove(teacher);
                await _context.SaveChangesAsync();
            }
        }

        public async ValueTask<IEnumerable<Teacher>> GetAllAsync()
        {
            IEnumerable<Teacher> teachers = await _context.Teachers.ToListAsync();

            return teachers;
        }
    }
}
