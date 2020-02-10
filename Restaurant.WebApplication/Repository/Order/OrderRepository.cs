using Microsoft.EntityFrameworkCore;
using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository
{
    public class OrderRepository : IOrderRepository
    {
        protected TestDBContext _applicationDbContext;
        public OrderRepository(TestDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Orders Create(Orders order)
        {
            var localOrder = GetOrder(order.Id);

            if (localOrder != null)
            {
                _applicationDbContext.Entry(localOrder).State = EntityState.Detached;
                _applicationDbContext.Orders.Update(order);
            }
            else
                _applicationDbContext.Orders.Add(order);
            _applicationDbContext.SaveChanges();
            return order;
        }

        public void Delete(Orders order)
        {
            _applicationDbContext.Orders.Remove(order);
            _applicationDbContext.SaveChanges();
        }

        public Orders GetOrder(int orderId)
        {
            try
            {
                var order = _applicationDbContext.Orders.Find(orderId);
                _applicationDbContext.Entry(order).Collection(p => p.OrderProduct).Load();
                return order;
            }
            catch
            {
                return null;
            }
        }

        public List<Orders> GetOrderByCustomerId(string customerId)
        {
            try
            {
                var order = _applicationDbContext.Orders.Where(x => x.CustomerId == customerId).ToList();
                return order;
            }
            catch
            {
                return null;
            }
        }
    }
}
