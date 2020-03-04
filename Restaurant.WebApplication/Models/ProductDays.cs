using System;
using System.Collections.Generic;

namespace Restaurant.WebApplication.Models
{
    public partial class ProductDays
    {
        public int ProductId { get; set; }
        public int Day { get; set; }
        public int Id { get; set; }

        public virtual Product Product { get; set; }
    }
}
