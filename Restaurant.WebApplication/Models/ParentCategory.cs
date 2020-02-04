using System;
using System.Collections.Generic;

namespace Restaurant.WebApplication.Models
{
    public partial class ParentCategory
    {
        public ParentCategory()
        {
            Category = new HashSet<Category>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Category> Category { get; set; }
    }
}
