using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeEntrySystem.API.Data;
using TimeEntrySystem.API.Models;

namespace TimeEntrySystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _repo;
        public EmployeesController(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<List<Employee>> GetEmployees()
        {
            var employees = await _repo.GetEmployees();
            return employees;
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> ClockIn(int id, int pin, string status) {
            var employee = await _repo.ClockIn(id, pin, status);
            if (employee == null) return StatusCode(500);
            return StatusCode(200);
        }

    }
}