using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository.Blogs
{
    interface IBlogImagesRepository
    {
        BlogImages Create(BlogImages blogImage);
        void Delete(BlogImages blogImage);
        BlogImages GetBlogImages(int imageId);
    }
}
