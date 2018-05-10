using DotNetCoreWithNorthWind.Models;

namespace DotNetCoreWithNorthWind.Services
{
    public interface IOrderService
    {
        Order Get(int id);
    }
}