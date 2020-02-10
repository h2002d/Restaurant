using Microsoft.EntityFrameworkCore;
using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        protected TestDBContext _applicationDbContext;
        public CustomerRepository(TestDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Customers Create(Customers customer)
        {

            var localCustomer = GetCustomer(customer.UserId);

            if (localCustomer != null)
            {
                _applicationDbContext.Entry(localCustomer).State = EntityState.Detached;
                _applicationDbContext.Customers.Update(customer);
            }
            else
                _applicationDbContext.Customers.Add(customer);
            _applicationDbContext.SaveChanges();
            return customer;
        }

        public void Delete(Customers customer)
        {
            _applicationDbContext.Customers.Remove(customer);
            _applicationDbContext.SaveChanges();
        }

        public Customers GetCustomer(string customerId)
        {
            try
            {
                var customer = _applicationDbContext.Customers.Find(customerId);
                //_applicationDbContext.SaveChanges();
                return customer;
            }
            catch
            {
                return null;
            }
        }
        public List<Customers> GetCustomers(bool? isWholesale)
        {
            try
            {
                var customer = new List<Customers>();
                if (isWholesale == null)
                    customer = _applicationDbContext.Customers.ToList();
                else if ((bool)isWholesale)
                    customer = _applicationDbContext.Customers.Where(x=>!String.IsNullOrEmpty(x.CompanyName)).ToList();
                else
                    customer = _applicationDbContext.Customers.Where(x => String.IsNullOrEmpty(x.CompanyName)).ToList();
                return customer;
            }
            catch
            {
                return null;
            }
        }
    }
}
