using Microsoft.EntityFrameworkCore;
using TourismSystem.Domain.Entities;

namespace AppartmentSystem.DataAccess.DataContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        public virtual DbSet<Ticket> Tickets { get; set; }
    }
}