using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TimeEntrySystem.API.Models;

namespace TimeEntrySystem.API.Data
{
    public class AdministratorRepository : IAdministratorRepository
    {
        private readonly DataContext _context;
        public AdministratorRepository(DataContext context)
        {
            _context = context;

        }
        public Task<Employee> CreateEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public async void DeleteEmployee(int id)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
        }

        public async Task<Employee> ReadEmployee(int id)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(emp => emp.Id == id);
            return employee;
        }

        public Task<Employee> UpdateEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }
    }
}