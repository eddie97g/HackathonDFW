using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeEntrySystem.API.Models;

namespace TimeEntrySystem.API.Data
{
    public interface IAdministratorRepository
    {
         void DeleteEmployee(int id);

         Task<Employee> UpdateEmployee(Employee employee);

         Task<Employee> CreateEmployee(Employee employee);

         Task<Employee> ReadEmployee(int id);




    }
}