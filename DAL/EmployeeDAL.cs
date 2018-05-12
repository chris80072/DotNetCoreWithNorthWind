using System.Linq;
using DotNetCoreWithNorthWind.Contexts;
using DotNetCoreWithNorthWind.Models;

namespace DotNetCoreWithNorthWind.DAL
{
    public class EmployeeDAL : IEmployeeDAL
    {
        private readonly EmployeeContext _employeeContext;

        public EmployeeDAL(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        public Employee Get(int id)
        {
            return _employeeContext.Employees.Where(e => e.EmployeeID.Equals(id)).SingleOrDefault();
        }
    }
}