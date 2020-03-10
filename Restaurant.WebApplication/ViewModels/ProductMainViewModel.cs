using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.ViewModels
{
    public class ProductMainViewModel
    {
        public List<Product> Products { get; set; }
        public int PageCount { get; set; }
    }
}
