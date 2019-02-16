using Microsoft.EntityFrameworkCore;
using TimeEntrySystem.API.Models;

namespace TimeEntrySystem.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Employee> Employees { get; set; }
    }
}