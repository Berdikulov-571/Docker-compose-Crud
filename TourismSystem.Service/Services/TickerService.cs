using AppartmentSystem.DataAccess.DataContexts;
using Microsoft.EntityFrameworkCore;
using TourismSystem.Domain.Entities;
using TourismSystem.Service.Interfaces;

namespace TourismSystem.Service.Services
{
    public class TickerService : ITickerRepository
    {
        private readonly ApplicationDbContext _context;

        public TickerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async ValueTask CreateAsync(Ticket ticker)
        {
            await _context.AddAsync(ticker);
            await _context.SaveChangesAsync();
        }

        public async ValueTask DeleteAsync(int ticketId)
        {
            Ticket ticket = await _context.Tickets.FirstOrDefaultAsync(x => x.TicketId == ticketId);

            if(ticket != null)
            {
                _context.Remove(ticket);
                await _context.SaveChangesAsync();
            }
        }

        public async ValueTask<IEnumerable<Ticket>> GetAllAsync()
        {
            var res = await _context.Tickets.ToListAsync();

            return res;
        }
    }
}
