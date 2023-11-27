using Microsoft.AspNetCore.Mvc;
using TourismSystem.Domain.Entities;
using TourismSystem.Service.Interfaces;

namespace TourismSystem.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TicketController : ControllerBase
    {
        private readonly ITickerRepository _repo;

        public TicketController(ITickerRepository repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public async ValueTask<IActionResult> PostAsync(Ticket ticket)
        {
            await _repo.CreateAsync(ticket);

            return Ok();
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(int ticketId)
        {
            await _repo.DeleteAsync(ticketId);

            return Ok();
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            IEnumerable<Ticket> classes = await _repo.GetAllAsync();

            return Ok(classes);
        }

    }
}
