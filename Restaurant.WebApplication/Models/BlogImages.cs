using System;
using System.Collections.Generic;

namespace Restaurant.WebApplication.Models
{
    public partial class BlogImages
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string ImagePath { get; set; }
        public DateTime UploadDate { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
