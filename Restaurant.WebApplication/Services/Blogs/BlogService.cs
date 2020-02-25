using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Repository;
using Restaurant.WebApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Services.Blogs
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _blogRepository;

        public BlogService(IBlogRepository blogRepository)
        {
            this._blogRepository = blogRepository;
        }

        public Blog Create(Blog blog)
        {
            return _blogRepository.Create(blog);
        }

        public BlogMainViewModel GetBlogMainViewModel(int page)
        {
            var blogs = _blogRepository.GetBlogs(page);
            var model = new BlogMainViewModel();
            model.Blogs = blogs;
            model.PageCount = (int)Math.Ceiling((decimal)_blogRepository.GetBlogsCount() / 10);
            return model;
        }

        public List<Blog> GetBlogs(int page)
        {
            return _blogRepository.GetBlogs(page);
        }

        Blog IBlogService.GetBlog(int Id)
        {
            return _blogRepository.GetBlog(Id);
        }
    }
}
