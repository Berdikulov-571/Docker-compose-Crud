using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Domain.Entities;
using SchoolSystem.Service.Interfaces;

namespace SchoolSystem.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepository _repo;

        public TeacherController(ITeacherRepository repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public async ValueTask<IActionResult> PostAsync(Teacher teacher)
        {
            await _repo.CreateAsync(teacher);

            return Ok();
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(int teacherId)
        {
            await _repo.DeleteAsync(teacherId);

            return Ok();
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            IEnumerable<Teacher> teachers = await _repo.GetAllAsync();

            return Ok(teachers);
        }
    }
}
