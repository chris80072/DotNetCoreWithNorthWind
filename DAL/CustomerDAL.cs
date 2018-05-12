using System.Linq;
using DotNetCoreWithNorthWind.Contexts;
using DotNetCoreWithNorthWind.Models;

namespace DotNetCoreWithNorthWind.DAL
{
    public class CustomerDAL : ICustomerDAL
    {
        private readonly CustomerContext _customerContext;

        public CustomerDAL(CustomerContext customerContext)
        {
            _customerContext = customerContext;
        }

        public Customer Get(string id)
        {
            return _customerContext.Customers.Where(c => c.CustomerID.Equals(id)).SingleOrDefault();
        }
    }
}