using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeEntrySystem.API.Data;
using TimeEntrySystem.API.Dtos;
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
        public async Task<IActionResult> TimeEntry(int id, [FromBody]EmployeeForTimeEntryDto employeeForTimeEntryDto) {
            var employee = await _repo.TimeEntry(id, employeeForTimeEntryDto);
            if (employee == null) return StatusCode(500);
            return StatusCode(200);
        }

    }
}