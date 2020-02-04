using System;
using System.Collections.Generic;

namespace Restaurant.WebApplication.Models
{
    public partial class OrderProduct
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public int Id { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
    }
}
