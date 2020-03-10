using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Repository;
using Restaurant.WebApplication.ViewModels;
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

        public ProductMainViewModel GetProductForAll(int page, int categoryId, string name)
        {
            ProductMainViewModel productMainViewModel = new ProductMainViewModel();

            var products = _productRepository.GetProductForAll(page, categoryId, name); 
            int count= (int)Math.Ceiling((decimal)_productRepository.GetProductForAllCount(categoryId, name) / 10);
            productMainViewModel.Products = products;
            productMainViewModel.PageCount = count;
            return productMainViewModel;
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
