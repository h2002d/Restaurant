using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.ViewModels
{
    public class ViewModelBase
    {
        public List<Category> Categories
        {
            get
            {
                var cat1 = new Category();
                cat1.Name = "Category1";
                cat1.Id = 1;
                cat1.Parent = null;
                List<Category> cat = new List<Category> { cat1, cat1, cat1 };
                return cat;
            }
        }
    }
}
