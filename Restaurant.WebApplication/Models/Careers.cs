using System;
using System.Collections.Generic;

namespace Restaurant.WebApplication.Models
{
    public partial class Careers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
