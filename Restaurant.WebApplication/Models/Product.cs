using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.WebApplication.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderProduct = new HashSet<OrderProduct>();
            ProductImages = new HashSet<ProductImages>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public int TypeId { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }
        public string Keys { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
        public string ProductDays { get; set; }
        public virtual ICollection<ProductImages> ProductImages { get; set; }
    }
}
