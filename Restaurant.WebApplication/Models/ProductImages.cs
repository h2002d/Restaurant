using System;
using System.Collections.Generic;

namespace Restaurant.WebApplication.Models
{
    public partial class ProductImages
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImagePath { get; set; }
        public DateTime UploadDate { get; set; }

        public virtual Products Product { get; set; }
    }
}
