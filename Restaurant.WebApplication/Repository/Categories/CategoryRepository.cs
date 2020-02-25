using Microsoft.EntityFrameworkCore;
using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        protected TestDBContext _applicationDbContext;
        public CategoryRepository(TestDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public Category Create(Category category)
        {
            var localCustomer = GetCategory(category.Id);

            if (localCustomer != null)
            {
                _applicationDbContext.Entry(localCustomer).State = EntityState.Detached;
                _applicationDbContext.Category.Update(category);
            }
            else
                _applicationDbContext.Category.Add(category);
            _applicationDbContext.SaveChanges();
            return category;
        }

        public void Delete(Category category)
        {
            _applicationDbContext.Category.Remove(category);
            _applicationDbContext.SaveChanges();
        }

        public Category GetCategory(int categoryId)
        {
            var category = _applicationDbContext.Category.Find(categoryId);
            _applicationDbContext.Entry(category).State = EntityState.Detached;
            return category;
        }
        public List<Category> GetCategories()
        {
            try
            {
                List<Category> category = new List<Category>();
                category = _applicationDbContext.Category.ToList();
                return category;
            }
            catch
            {
                return null;
            }
        }
    }
}
