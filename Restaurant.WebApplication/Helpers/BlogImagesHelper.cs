﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Repository.Blogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Helpers
{
    public class BlogImagesHelper
    {
        protected TestDBContext _commerceDbContext;

        private IHostingEnvironment _hostingEnvironment;
        public BlogImagesHelper(TestDBContext commerceDbContext, IHostingEnvironment hostingEnvironment)
        {
            _commerceDbContext = commerceDbContext;
            _hostingEnvironment = hostingEnvironment;
        }

        public void SaveProductImage(List<IFormFile> formFiles, int blogId)
        {
            BlogImagesRepository imageRepository = new BlogImagesRepository(_commerceDbContext);

            List<BlogImages> productImages = new List<BlogImages>();
            string shortLocation = $"\\images\\blogs\\{blogId}\\";
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
                    var filePath = Path.Combine(uploads, file.FileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    BlogImages blog = new BlogImages();
                    blog.ImagePath = $"/images/blogs/{blogId}/{file.FileName}";
                    blog.BlogId = blogId;
                    blog.UploadDate = DateTime.Now;
                    imageRepository.Create(blog);
                }
            }
        }
    }
}
