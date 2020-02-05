using Microsoft.EntityFrameworkCore;
using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository.Blogs
{
    public class BlogImagesRepository : IBlogImagesRepository
    {

        protected TestDBContext _applicationDbContext;
        public BlogImagesRepository(TestDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public BlogImages Create(BlogImages blogImage)
        {
            blogImage.UploadDate = DateTime.Now;
            var localCareer = GetBlogImages(blogImage.Id);

            if (localCareer != null)
            {
                _applicationDbContext.Entry(localCareer).State = EntityState.Detached;
                _applicationDbContext.BlogImages.Update(blogImage);
            }
            else
                _applicationDbContext.BlogImages.Add(blogImage);
            _applicationDbContext.SaveChanges();
            return blogImage;
        }

        public void Delete(BlogImages blogImage)
        {
            _applicationDbContext.BlogImages.Remove(blogImage);
            _applicationDbContext.SaveChanges();
        }

        public BlogImages GetBlogImages(int imageId)
        {
            var blogImages = _applicationDbContext.BlogImages.Find(imageId);
            return blogImages;
        }
    }
}
