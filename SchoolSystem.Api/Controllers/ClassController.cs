using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Domain.Entities;
using SchoolSystem.Service.Interfaces;

namespace SchoolSystem.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ClassController : ControllerBase
    {
        private readonly IClassRepository _repo;

        public ClassController(IClassRepository repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public async ValueTask<IActionResult> PostAsync(Class @class)
        {
            await _repo.CreateAsync(@class);

            return Ok();
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(int classId)
        {
            await _repo.DeleteAsync(classId);

            return Ok();
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            IEnumerable<Class> classes = await _repo.GetAllAsync();

            return Ok(classes);
        }
    }
}
