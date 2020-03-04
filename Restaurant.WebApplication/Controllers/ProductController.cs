using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Helpers;
using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Repository;
using Restaurant.WebApplication.Services.Products;
using Restaurant.WebApplication.ViewModels;

namespace Restaurant.WebApplication.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private TestDBContext _dbContext;
        private IProductService _productService;
        private IHostingEnvironment _hostingEnvironment;
        private readonly IMapper _mapper;

        public ProductController(ILogger<ProductController> logger, TestDBContext dbContext, IHostingEnvironment hostingEnvironment, IMapper mapper, IProductService productService)
        {
            _logger = logger;
            _dbContext = dbContext;
            _hostingEnvironment = hostingEnvironment;
            _productService = productService;
            _mapper = mapper;
        }


        public IActionResult Index(int Id)
        {
            var model = new ProductDetailViewModel();
            var product = _productService.GetProduct(Id);
            return View(product);
        }

        public IActionResult Create(int Id)
        {
            ParentCategoryRepository repository = new ParentCategoryRepository(_dbContext);
            ViewBag.ParentCategories = new SelectList(repository.GetParentCategories(), "Id", "Name");
            var product = _productService.GetProduct(Id);
            return View(_mapper.Map<ProductViewModel>(product));
        }

        [HttpPost]
        public IActionResult Create(ProductViewModel product, [FromForm]List<IFormFile> formFiles)
        {
            try
            {
                var productNew = _productService.Create(_mapper.Map<Product>(product));
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



        #region All
        public IActionResult All(int page,int categoryId,string q)
        {
            var products = _productService.GetProductForAll(page, categoryId, q);
            var prodModel = new ProductMainViewModel();
            prodModel.Products = products;
            return View(prodModel);
        }


        #endregion


    }
}