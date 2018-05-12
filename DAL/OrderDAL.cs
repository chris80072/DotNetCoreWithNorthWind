using System.Linq;
using DotNetCoreWithNorthWind.Contexts;
using DotNetCoreWithNorthWind.Models;

namespace DotNetCoreWithNorthWind.DAL
{
    public class OrderDAL :IOrderDAL
    {
        private readonly OrderContext _orderContext;

        public OrderDAL(OrderContext orderContext)
        {
            _orderContext = orderContext;
        }
        
        public Order Get(int id)
        {
            return _orderContext.Orders.Where(o => o.OrderID.Equals(id)).SingleOrDefault();;
        }

        public int Create(Order order)
        {
            _orderContext.Add(order);
            _orderContext.SaveChanges();
            return order.OrderID;
        }

        public bool Update(Order order)
        {
            var oriOrrder = _orderContext.Orders.SingleOrDefault(o => o.OrderID.Equals(order.OrderID));

            if (oriOrrder != null)
            {
                _orderContext.Entry(oriOrrder).CurrentValues.SetValues(order);
                _orderContext.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Delete(int id)
        {
            var oriOrrder = _orderContext.Orders.SingleOrDefault(o => o.OrderID.Equals(id));

            if (oriOrrder != null)
            {
                _orderContext.Orders.Remove(oriOrrder);
                _orderContext.SaveChanges();
                return true;
            }

            return false;
        }
    }
}