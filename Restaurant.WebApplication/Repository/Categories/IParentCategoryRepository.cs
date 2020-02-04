using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository.Categories
{
    interface IParentCategoryRepository
    {
        ParentCategory Create(ParentCategory parentCategory);
        void Delete(ParentCategory parentCategory);
        ParentCategory GetParentCategory(int parentCategoryId);
    }
}
