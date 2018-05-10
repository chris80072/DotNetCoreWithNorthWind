using System.Linq;
using DotNetCoreWithNorthWind.Contexts;
using DotNetCoreWithNorthWind.Models;

namespace DotNetCoreWithNorthWind.Services
{
    public class OrderService :IOrderService
    {
        private readonly OrderContext _orderContext;
        private readonly EmployeeContext _employeeContext;
        private readonly CustomerContext _customerContext;

        public OrderService(OrderContext orderContext, EmployeeContext employeeContext, CustomerContext customerContext)
        {
            _orderContext = orderContext;
            _employeeContext = employeeContext;
            _customerContext = customerContext;
        }

        public Order Get(int id)
        {
            var order = new Order();
            order = _orderContext.Orders.Where(o => o.OrderID.Equals(id)).FirstOrDefault();
            if(order != null)
            {
                order.Customer = _customerContext.Customers.Where(c => c.CustomerID.Equals(order.CustomerID)).FirstOrDefault();
                order.Employee = _employeeContext.Employees.Where(e => e.EmployeeID.Equals(order.EmployeeID)).FirstOrDefault();
            }
            
            return order;
        }
    }
}