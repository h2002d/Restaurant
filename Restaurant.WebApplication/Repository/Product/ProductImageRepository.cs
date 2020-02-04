using Microsoft.EntityFrameworkCore;
using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository.Product
{
    public class ProductImageRepository : IProductImageRepository
    {
        protected TestDBContext _applicationDbContext;
        public ProductImageRepository(TestDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public ProductImages Create(ProductImages productImage)
        {
            var localImage = GetProductImage(productImage.Id);

            if (localImage != null)
            {
                _applicationDbContext.Entry(localImage).State = EntityState.Detached;
                _applicationDbContext.ProductImages.Update(productImage);
            }
            else
                _applicationDbContext.ProductImages.Add(productImage);
            _applicationDbContext.SaveChanges();
            return productImage;
        }

        public void Delete(ProductImages productImage)
        {
            _applicationDbContext.ProductImages.Remove(productImage);
            _applicationDbContext.SaveChanges();
        }

        public ProductImages GetProductImage(int productId)
        {
            var product = _applicationDbContext.ProductImages.Find(productId);
            return product;
        }
    }
}
