using DotNetCoreWithNorthWind.Models;

namespace DotNetCoreWithNorthWind.DAL
{
    public interface IEmployeeDAL
    {
        Employee Get(int Id);
    }
}