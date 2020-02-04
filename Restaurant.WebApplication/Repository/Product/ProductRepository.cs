using Microsoft.EntityFrameworkCore;
using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository.Product
{
    public class ProductRepository : IProductRepository
    {
        protected TestDBContext _applicationDbContext;
        public ProductRepository(TestDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public Products Create(Products product)
        {
            var localCustomer = GetProduct(product.Id);
            product.CreateDate = DateTime.Now;
            if (localCustomer != null)
            {
                _applicationDbContext.Entry(localCustomer).State = EntityState.Detached;
                _applicationDbContext.Products.Update(product);
            }
            else
                _applicationDbContext.Products.Add(product);
            _applicationDbContext.SaveChanges();
            return product;
        }

        public void Delete(Products product)
        {
            _applicationDbContext.Products.Remove(product);
            _applicationDbContext.SaveChanges();
        }

        public Products GetProduct(int productId)
        {
            try
            {
                var product = _applicationDbContext.Products.Find(productId);
                _applicationDbContext.Entry(product).Reference(p => p.Category).Load();
                _applicationDbContext.Entry(product).Collection(p => p.ProductImages).Load();
                //_applicationDbContext.SaveChanges();
                return product;
            }
            catch
            {
                return null;
            }
        }
    }
}
