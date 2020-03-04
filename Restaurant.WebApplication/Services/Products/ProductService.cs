using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product Create(Product product)
        {
            return _productRepository.Create(product);
        }

        public void Delete(Product product)
        {
            _productRepository.Delete(product);
        }

        public Product GetProduct(int productId)
        {
            return _productRepository.GetProduct(productId);
        }

        public List<Product> GetProductForAll(int page, int categoryId, string name)
        {
            return _productRepository.GetProductForAll(page, categoryId, name);
        }

        public List<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }

        public List<Product> GetProductsByCategoryId(int categoryId)
        {

            return _productRepository.GetProductsByCategoryId(categoryId);
        }

        public List<Product> GetProductsByName(string name)
        {
            return _productRepository.GetProductsByName(name);
        }
    }
}
