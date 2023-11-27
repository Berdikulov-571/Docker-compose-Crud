using TourismSystem.Domain.Entities;

namespace TourismSystem.Service.Interfaces
{
    public interface ITickerRepository
    {
        ValueTask CreateAsync(Ticket ticker);
        ValueTask DeleteAsync(int ticketId);
        ValueTask<IEnumerable<Ticket>> GetAllAsync();
    }
}
