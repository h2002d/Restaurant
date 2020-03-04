using Restaurant.WebApplication.ViewModels;
using System;
using System.Collections.Generic;

namespace Restaurant.WebApplication.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ParentId { get; set; }

        public virtual ParentCategory Parent { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
