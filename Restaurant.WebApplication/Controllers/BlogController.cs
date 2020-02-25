using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Helpers;
using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Repository;
using Restaurant.WebApplication.Services.Blogs;
using Restaurant.WebApplication.ViewModels;

namespace Restaurant.WebApplication.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILogger<BlogController> _logger;
        private TestDBContext _dbContext;
        private IBlogService _blogService;
        private IHostingEnvironment _hostingEnvironment;
        public BlogController(ILogger<BlogController> logger, TestDBContext dbContext, IHostingEnvironment hostingEnvironment, IBlogService blogService)
        {
            _logger = logger;
            _dbContext = dbContext;
            _hostingEnvironment = hostingEnvironment;
            _blogService = blogService;
        }
        public IActionResult All()
        {
            var blogs = _blogService.GetBlogs(0);
            return View(blogs);
        }

        public IActionResult Index(int Id, int page = 1)
        {
            if (Id == 0)
            {
                var model = _blogService.GetBlogMainViewModel(page);
                return View(model);
            }
            else
            {
                var blog = _blogService.GetBlog(Id);
                var model = new BlogDetailViewModel();
                model.Blog = blog;
                return View("BlogDetail", model);
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog blog, [FromForm]List<IFormFile> formFiles)
        {
            try
            {
                var blogNew = _blogService.Create(blog);

                BlogImagesHelper helper = new BlogImagesHelper(_dbContext, _hostingEnvironment);
                helper.SaveProductImage(formFiles, blogNew.Id);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(blog);
            }
            return RedirectToAction("Create");
        }
    }
}