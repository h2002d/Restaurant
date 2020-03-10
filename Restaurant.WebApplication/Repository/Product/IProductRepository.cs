using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository
{
    public interface IProductRepository
    {
        Product Create(Product product);
        void Delete(Product product);
        Product GetProduct(int productId);
        List<Product> GetProducts();
        List<Product> GetProductsByCategoryId(int categoryId);
        List<Product> GetProductsByName(string name);
        List<Product> GetProductForAll(int page, int categoryId, string name);
        int GetProductForAllCount(int categoryId, string name);
    }
}
