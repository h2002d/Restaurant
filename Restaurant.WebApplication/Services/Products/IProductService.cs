using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Services.Products
{
    public interface IProductService
    {
        Product Create(Product product);
        void Delete(Product product);
        Product GetProduct(int productId);
        List<Product> GetProducts();
        List<Product> GetProductsByCategoryId(int categoryId);
        List<Product> GetProductsByName(string name);
        ProductMainViewModel GetProductForAll(int page, int categoryId, string name);
    }
}
