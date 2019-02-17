using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeEntrySystem.API.Data;

namespace TimeEntrySystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministratorController : ControllerBase
    {
        private readonly IAdministratorRepository _repo;
        public AdministratorController(IAdministratorRepository repo)
        {
            _repo = repo;

        }

        [HttpDelete("{id}")]
        public void Delete(int id) {
            _repo.DeleteEmployee(id);
        }

        // [HttpGet("{id}")]
        // public async Task< Get(int id) {
        //     var employee = await _repo.ReadEmployee(id);
        //     if (employee == null) { return StatusCode(401); }
        //     return 

        // }
    }
}