using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant.WebApplication.Models;

namespace Restaurant.WebApplication.Repository.Categories
{
    interface ICategoryRepository
    {
        Category Create(Category customer);
        void Delete(Category customer);
        Category GetCategory(int customerId);
        List<Category> GetCategories();
    }
}
