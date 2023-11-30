using Microsoft.EntityFrameworkCore;
using SchoolSystem.Domain.Entities;

namespace AppartmentSystem.DataAccess.DataContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
    }
}