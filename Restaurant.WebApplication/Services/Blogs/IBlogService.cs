using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Services.Blogs
{
    public interface IBlogService
    {
        BlogMainViewModel GetBlogMainViewModel(int page);
        Blog GetBlog(int Id);
        Blog Create(Blog blog);
        List<Blog> GetBlogs(int page);
    }
}
