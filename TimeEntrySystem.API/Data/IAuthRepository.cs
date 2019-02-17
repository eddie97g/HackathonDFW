using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeEntrySystem.API.Models;

namespace TimeEntrySystem.API.Data
{
    public interface IAuthRepository
    {
         Task<Employee> Login(string username, string password);

    }
}