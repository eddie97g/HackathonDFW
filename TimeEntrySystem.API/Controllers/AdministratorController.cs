using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeEntrySystem.API.Data;
using TimeEntrySystem.API.Dtos;
using TimeEntrySystem.API.Models;

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

        [HttpGet("{id}")]
        public async Task<Employee> Get(int id) {
            var employee = await _repo.ReadEmployee(id);
            return employee;
        }

        // [HttpPost]
        // public Task<IActionResult> Create(EmployeeForCreationDto employeeForCreationDto) {
            
        // }
    }
}