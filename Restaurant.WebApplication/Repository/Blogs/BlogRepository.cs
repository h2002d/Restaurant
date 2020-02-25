using Microsoft.EntityFrameworkCore;
using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository
{
    public class BlogRepository : IBlogRepository
    {
        protected TestDBContext _applicationDbContext;
        public BlogRepository(TestDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Blog Create(Blog blog)
        {
            blog.CreateDate = DateTime.Now;
            var localCareer = GetBlog(blog.Id);

            if (localCareer != null)
            {
                _applicationDbContext.Entry(localCareer).State = EntityState.Detached;
                _applicationDbContext.Blog.Update(blog);
            }
            else
                _applicationDbContext.Blog.Add(blog);
            _applicationDbContext.SaveChanges();
            return blog;
        }

        public void Delete(Blog blog)
        {
            _applicationDbContext.Blog.Remove(blog);
            _applicationDbContext.SaveChanges();
        }

        public Blog GetBlog(int blogId)
        {

            var blog = _applicationDbContext.Blog.Find(blogId);
            if (blog != null)
                _applicationDbContext.Entry(blog).Collection(p => p.BlogImages).Load();

            return blog;
        }
        public List<Blog> GetBlogs(int page)
        {

            var blogs = _applicationDbContext.Blog.ToList();
            if (page != 0)
                blogs = _applicationDbContext.Blog.Skip((page - 1) * 10).Take(10).ToList(); 
            foreach (var blog in blogs)
            {
                _applicationDbContext.Entry(blog).Collection(p => p.BlogImages).Load();
                //_applicationDbContext.Entry(blog).State = EntityState.Detached;
            }
            return blogs.ToList();
        }

        public int GetBlogsCount()
        {
            return _applicationDbContext.Blog.Count();
        }
    }
}
