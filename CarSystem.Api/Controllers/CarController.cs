using CarSystem.Domain.Entities;
using CarSystem.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarSystem.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _repo;

        public CarController(ICarRepository repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public async ValueTask<IActionResult> PostAsync(CarModel model) 
        {
            await _repo.CreateAsync(model);

            return Ok();
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            IEnumerable<CarModel> cars = await _repo.GetAllAsync();

            return Ok(cars);
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(int CarId)
        {
            await _repo.DeleteAsync(CarId);

            return Ok();
        }
    }
}
