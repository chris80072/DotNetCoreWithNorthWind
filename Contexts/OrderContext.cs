using DotNetCoreWithNorthWind.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreWithNorthWind.Contexts
{
  public class OrderContext : DbContext
  {
    public OrderContext(DbContextOptions<OrderContext> options) : base(options)
    {
    }

    public DbSet<Order> Orders { get; set; }
  }
}