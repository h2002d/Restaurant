using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository
{
    public interface IOrderRepository
    {
        Orders Create(Orders order);
        void Delete(Orders order);
        Orders GetOrder(int orderId);
        List<Orders> GetOrderByCustomerId(string customerId);
    }
}
