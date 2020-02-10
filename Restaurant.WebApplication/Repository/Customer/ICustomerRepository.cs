using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository
{
    public interface ICustomerRepository
    {
        Customers Create(Customers customer);
        void Delete(Customers customer);
        Customers GetCustomer(string customerId);
        List<Customers> GetCustomers(bool? isWholesale);
    }
}
