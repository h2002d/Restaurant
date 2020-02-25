using Restaurant.WebApplication.ViewModels;
using System;
using System.Collections.Generic;

namespace Restaurant.WebApplication.Models
{
    public partial class Category : ViewModelBase
    {
        public Category()
        {
            Products = new HashSet<Products>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ParentId { get; set; }

        public virtual ParentCategory Parent { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}
