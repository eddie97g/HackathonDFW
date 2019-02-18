using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TimeEntrySystem.API.Dtos;
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

        public async Task<Employee> TimeEntry(int id, EmployeeForTimeEntryDto employeeForTimeEntryDto) {
            var employee = await _context.Employees.FirstOrDefaultAsync(emp => emp.Id == id);
            if (employee.PIN == employeeForTimeEntryDto.PIN) {
                if (employee.Status == employeeForTimeEntryDto.Status) return null;

                else if (employee.Status == "in" && (employeeForTimeEntryDto.Status == "out" || employeeForTimeEntryDto.Status == "break")){
                    employee.Status = employeeForTimeEntryDto.Status;
                }
                else if (employee.Status == "break" && employeeForTimeEntryDto.Status == "in") {
                    employee.Status = employeeForTimeEntryDto.Status;
                }
                else if (employee.Status == "out" && employeeForTimeEntryDto.Status == "in") {
                    employee.Status = employeeForTimeEntryDto.Status;
                }
                else {
                    return null;
                }
                
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