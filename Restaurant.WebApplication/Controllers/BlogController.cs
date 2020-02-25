using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
        private readonly TestDBContext _dbContext;
        private readonly IBlogService _blogService;
        private readonly IBlogImagesService _blogImageService;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IMapper _mapper;


        public BlogController(ILogger<BlogController> logger, TestDBContext dbContext, IHostingEnvironment hostingEnvironment, IBlogService blogService,
            IMapper mapper, IBlogImagesService blogImageService)
        {
            _logger = logger;
            _dbContext = dbContext;
            _hostingEnvironment = hostingEnvironment;
            _blogService = blogService;
            _blogImageService = blogImageService;
            _mapper = mapper;
        }

        public IActionResult All()
        {
            var blogs = _blogService.GetBlogs(0);
            var model = new BlogMainViewModel();
            model.Blogs = blogs;
            return View(model);
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

        public IActionResult Create(int Id)
        {
            var blog = _blogService.GetBlog(Id);
            return View(_mapper.Map<BlogViewModel>(blog));
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
            return RedirectToAction("Create", new { id = blog.Id });
        }

        public IActionResult DeleteImage(int Id)
        {
            var image = _blogImageService.GetBlogImage(Id);
            _blogImageService.Delete(image);
            return RedirectToAction("Create", new { id = image.BlogId });
        }
    }
}