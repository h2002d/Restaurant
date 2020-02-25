using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Services.Blogs
{
    public class BlogImageService : IBlogImagesService
    {
        private readonly IBlogImagesRepository _blogImagesRepository;
        public BlogImageService(IBlogImagesRepository blogImagesRepository)
        {
            _blogImagesRepository = blogImagesRepository;
        }

        public void Delete(BlogImages image)
        {
            _blogImagesRepository.Delete(image);
        }

        public BlogImages GetBlogImage(int id)
        {
            return _blogImagesRepository.GetBlogImages(id);
        }
    }
}
