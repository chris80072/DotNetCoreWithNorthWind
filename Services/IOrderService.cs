using DotNetCoreWithNorthWind.Models;

namespace DotNetCoreWithNorthWind.Services
{
    public interface IOrderService
    {
        Order Get(int id);
        int Create(Order order);
        bool Update(Order order);
        bool Delete(int id);
    }
}