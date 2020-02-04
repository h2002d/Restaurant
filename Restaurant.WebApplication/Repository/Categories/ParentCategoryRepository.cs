using Microsoft.EntityFrameworkCore;
using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository.Categories
{
    public class ParentCategoryRepository : IParentCategoryRepository
    {
        protected TestDBContext _applicationDbContext;
        public ParentCategoryRepository(TestDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public ParentCategory Create(ParentCategory category)
        {
            var localCustomer = GetParentCategory(category.Id);

            if (localCustomer != null)
            {
                _applicationDbContext.Entry(localCustomer).State = EntityState.Detached;
                _applicationDbContext.ParentCategory.Update(category);
            }
            else
                _applicationDbContext.ParentCategory.Add(category);
            _applicationDbContext.SaveChanges();
            return category;
        }

        public void Delete(ParentCategory category)
        {
            _applicationDbContext.ParentCategory.Remove(category);
            _applicationDbContext.SaveChanges();
        }

        public ParentCategory GetParentCategory(int parentCategoryId)
        {
            try
            {
                var category = _applicationDbContext.ParentCategory.Find(parentCategoryId);
                _applicationDbContext.Entry(category).Collection(p => p.Category).Load();
                return category;
            }
            catch
            {
                return null;
            }
        }
        public List<ParentCategory> GetParentCategories()
        {
            try
            {
                List<ParentCategory> category = new List<ParentCategory>();
                category = _applicationDbContext.ParentCategory.ToList();
                return category;
            }
            catch
            {
                return null;
            }
        }
    }
}
