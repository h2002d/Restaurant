using Microsoft.EntityFrameworkCore;
using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository
{
    public class ProductRepository : IProductRepository
    {
        protected TestDBContext _applicationDbContext;
        public ProductRepository(TestDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public Product Create(Product product)
        {
            product.CreateDate = DateTime.Now;
            if (product.Id != 0)
            {
                _applicationDbContext.Products.Update(product);
            }
            else
                _applicationDbContext.Products.Add(product);
            _applicationDbContext.SaveChanges();
            return product;
        }

        public void Delete(Product product)
        {
            _applicationDbContext.Products.Remove(product);
            _applicationDbContext.SaveChanges();
        }

        public Product GetProduct(int productId)
        {
            try
            {
                var product = _applicationDbContext.Products.Find(productId);
                _applicationDbContext.Entry(product).Reference(p => p.Category).Load();
                _applicationDbContext.Entry(product).Collection(p => p.ProductImages).Load();
                return product;
            }
            catch
            {
                return null;
            }
        }

        public List<Product> GetProductForAll(int page, int categoryId, string name)
        {

            var products = _applicationDbContext.Products.Where(x => categoryId == 0 ? true : x.CategoryId == categoryId);
            products=products.Where(x => String.IsNullOrEmpty(name) ? true : x.Name.Contains(name)).Skip((page - 1) * 10).Take(10);
            return products.ToList();
        }

        public int GetProductForAllCount(int categoryId, string name)
        {

            var count = _applicationDbContext.Products.Where(x => categoryId == 0 ? true : x.CategoryId == categoryId && String.IsNullOrEmpty(name) ? true : x.Name.Contains(name)).Count();
            return count;
        }

        public List<Product> GetProducts()
        {
            return _applicationDbContext.Products.ToList();
        }

        public List<Product> GetProductsByCategoryId(int categoryId)
        {

            return _applicationDbContext.Products.Where(x => x.CategoryId == categoryId).ToList();
        }

        public List<Product> GetProductsByName(string name)
        {
            //need to test
            return _applicationDbContext.Products.Where(x => x.Name.Contains(name)).ToList();
        }
    }
}
