using Microsoft.AspNetCore.Mvc.Rendering;
using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public int TypeId { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }
        public string Keys { get; set; }
        public int CategoryId { get; set; }
        public string ProductDays { get; set; }
        public SelectList ParentCategory { get; set; }
        public List<ProductImages> ProductImages { get; set; }

    }
}
