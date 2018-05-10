using DotNetCoreWithNorthWind.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreWithNorthWind.Contexts
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}