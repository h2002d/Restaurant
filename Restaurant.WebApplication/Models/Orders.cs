using System;
using System.Collections.Generic;

namespace Restaurant.WebApplication.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        public int Id { get; set; }
        public string CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public int CouponId { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public int StatusId { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual OrderStatus Status { get; set; }
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
