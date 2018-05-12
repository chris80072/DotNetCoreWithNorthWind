using DotNetCoreWithNorthWind.Models;

namespace DotNetCoreWithNorthWind.DAL
{
    public interface ICustomerDAL
    {
        Customer Get(string id);
    }
}