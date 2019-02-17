using System.Collections.Generic;
using System.Threading.Tasks;
using TimeEntrySystem.API.Models;

namespace TimeEntrySystem.API.Data
{
    public interface IEmployeeRepository
    {
         Task<List<Employee>> GetEmployees();

         Task<Employee> ClockIn(int id, int pin, string status);
    }
}