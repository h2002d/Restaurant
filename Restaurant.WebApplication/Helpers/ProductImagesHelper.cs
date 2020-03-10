using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Helpers
{
    public class ProductImagesHelper
    {
        protected TestDBContext _commerceDbContext;

        private IHostingEnvironment _hostingEnvironment;
        public ProductImagesHelper(TestDBContext commerceDbContext, IHostingEnvironment hostingEnvironment)
        {
            _commerceDbContext = commerceDbContext;
            _hostingEnvironment = hostingEnvironment;
        }

        public void SaveProductImage(List<IFormFile> formFiles, int productId)
        {
            ProductImageRepository imageRepository = new ProductImageRepository(_commerceDbContext);

            List<ProductImages> productImages = new List<ProductImages>();
            string shortLocation = $"\\images\\products\\{productId}\\";
            string uploads = Path.Combine(_hostingEnvironment.WebRootPath + shortLocation);
            if (!Directory.Exists(uploads))
            {
                DirectoryInfo di = Directory.CreateDirectory(uploads);
            }
            foreach (var file in formFiles)
            {
                //string fileName = file.FileName;

                if (file.Length > 0)
                {
                    //item.CopyTo(fileStream);

                    var timeSpan = DateTime.Now.ToString("yyyyMMddHHmmssffff");
                    var filePath = Path.Combine(uploads, file.FileName + timeSpan);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    ProductImages product = new ProductImages();
                    product.ImagePath = $"/images/products/{productId}/{file.FileName + timeSpan}";
                    product.ProductId = productId;
                    product.UploadDate = DateTime.Now;
                    imageRepository.Create(product);
                }
            }
        }
    }
}
