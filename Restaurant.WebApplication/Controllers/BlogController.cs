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
using Restaurant.WebApplication.Repository.Blogs;
using Restaurant.WebApplication.Repository.Career;

namespace Restaurant.WebApplication.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILogger<BlogController> _logger;
        private TestDBContext _dbContext;
        private BlogRepository blogRepository;
        private IHostingEnvironment _hostingEnvironment;
        public BlogController(ILogger<BlogController> logger, TestDBContext dbContext, IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            _dbContext = dbContext;
            _hostingEnvironment = hostingEnvironment;
            blogRepository = new BlogRepository(dbContext);
        }

        public IActionResult Index(int Id)
        {
            var blog = blogRepository.GetBlog(Id);
            return View(blog);
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
                var blogNew = blogRepository.Create(blog);

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