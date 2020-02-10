using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Helpers;
using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Repository;

namespace Restaurant.WebApplication.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private TestDBContext _dbContext;
        private IProductRepository _productRepository;
        private IHostingEnvironment _hostingEnvironment;
        public ProductController(ILogger<ProductController> logger, TestDBContext dbContext, IHostingEnvironment hostingEnvironment, IProductRepository productRepository)
        {
            _logger = logger;
            _dbContext = dbContext;
            _hostingEnvironment = hostingEnvironment;
            _productRepository = productRepository;
        }
        public IActionResult Index(int Id)
        {
            var product = _productRepository.GetProduct(Id);
            return View(product);
        }
        public IActionResult Create()
        {
            ParentCategoryRepository repository = new ParentCategoryRepository(_dbContext);
            ViewBag.ParentCategories = new SelectList(repository.GetParentCategories(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Products product, [FromForm]List<IFormFile> formFiles)
        {

            try
            {
                var productNew = _productRepository.Create(product);

                ProductImagesHelper helper = new ProductImagesHelper(_dbContext, _hostingEnvironment);
                helper.SaveProductImage(formFiles, productNew.Id);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(product);
            }
            return RedirectToAction("Create");
        }
    }
}