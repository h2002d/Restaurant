using System;
using System.Collections.Generic;

namespace Restaurant.WebApplication.Models
{
    public partial class Blog
    {
        public Blog()
        {
            BlogImages = new HashSet<BlogImages>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public string Keys { get; set; }

        public virtual ICollection<BlogImages> BlogImages { get; set; }
    }
}
