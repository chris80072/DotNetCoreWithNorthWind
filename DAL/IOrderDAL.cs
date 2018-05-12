using DotNetCoreWithNorthWind.Models;

namespace DotNetCoreWithNorthWind.DAL
{
    public interface IOrderDAL
    {
        Order Get(int id);
        int Create(Order order);
        bool Update(Order order);
        bool Delete(int id);
    }
}