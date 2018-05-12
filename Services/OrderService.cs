using System.Linq;
using DotNetCoreWithNorthWind.DAL;
using DotNetCoreWithNorthWind.Models;

namespace DotNetCoreWithNorthWind.Services
{
    public class OrderService :IOrderService
    {
        private readonly IOrderDAL _orderDAL;
        private readonly ICustomerDAL _customerDAL;
        private readonly IEmployeeDAL _employeeDAL;

        public OrderService(IOrderDAL orderDAL, ICustomerDAL customerDAL, IEmployeeDAL employeeDAL)
        {
            _orderDAL = orderDAL;
            _customerDAL = customerDAL;
            _employeeDAL = employeeDAL;
        }

        public Order Get(int id)
        {
            var order = _orderDAL.Get(id);

            if(order != null)
            {
                order.Customer = _customerDAL.Get(order.CustomerID);
                order.Employee = _employeeDAL.Get(order.EmployeeID);
            }
            
            return order;
        }

        public int Create(Order order)
        {
            return _orderDAL.Create(order);
        }

        public bool Update(Order order)
        {
            return _orderDAL.Update(order);
        }

        public bool Delete(int id)
        {
            return _orderDAL.Delete(id);
        }
    }
}