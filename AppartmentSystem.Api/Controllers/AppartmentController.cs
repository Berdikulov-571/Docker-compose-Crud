using AppartmentSystem.Domain.Entities;
using AppartmentSystem.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AppartmentSystem.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AppartmentController : ControllerBase
    {
        private readonly IAppartmentRepository _repository;
        
        public AppartmentController(IAppartmentRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async ValueTask<IActionResult> PostAsync(AppartmentModel model)
        {
            await _repository.CreateAsync(model);

            return Ok();
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            IEnumerable<AppartmentModel> models = await _repository.GetAllAsync();

            return Ok(models);
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(int AppartmentId)
        {
            await _repository.DeleteAsync(AppartmentId);

            return Ok();
        }
    }
}
