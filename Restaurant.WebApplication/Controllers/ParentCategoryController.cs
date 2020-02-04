using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Repository.Categories;
using Restaurant.WebApplication.Repository.Product;

namespace Restaurant.WebApplication.Controllers
{
    public class ParentCategoryController : Controller
    {
        private TestDBContext _dbContext;
        private ParentCategoryRepository categoryRepository;
        private readonly ILogger<ParentCategoryController> _logger;
        public ParentCategoryController(ILogger<ParentCategoryController> logger, TestDBContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
            categoryRepository = new ParentCategoryRepository(dbContext);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ParentCategory parentCategory)
        {
            categoryRepository.Create(parentCategory);
            return View();
        }
    }
}