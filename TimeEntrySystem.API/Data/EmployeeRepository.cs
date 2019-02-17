using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TimeEntrySystem.API.Models;

namespace TimeEntrySystem.API.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _context;
        public EmployeeRepository(DataContext context)
        {
            _context = context;

        }
        public async Task<List<Employee>> GetEmployees()
        {
            var employees = await _context.Employees.ToListAsync();
            return employees;
        }

        public async Task<Employee> ClockIn(int id, [FromBody]int pin, [FromBody]string status) {
            var employee = await _context.Employees.FirstOrDefaultAsync(emp => emp.Id == id);
            if (employee.PIN == 1234) {
                employee.Status = status;
                _context.Employees.Update(employee);
                await _context.SaveChangesAsync();
                return employee;
            }
            else {
                return null;
            }
        }
    }
}