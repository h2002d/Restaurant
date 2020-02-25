using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Services.Blogs
{
    public interface IBlogImagesService
    {
        void Delete(BlogImages image);
        BlogImages GetBlogImage(int id);
    }
}
