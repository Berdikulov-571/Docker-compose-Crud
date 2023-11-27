using Microsoft.EntityFrameworkCore;
using TourismSystem.Domain.Entities;

namespace AppartmentSystem.DataAccess.DataContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Ticket> Tickets { get; set; }
    }
}