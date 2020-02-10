using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Repository;

namespace Restaurant.WebApplication.Controllers
{
    public class CategoryController : Controller
    {
        private TestDBContext _dbContext;
        private ICategoryRepository _categoryRepository;
        private readonly ILogger<CategoryController> _logger;
        public CategoryController(ILogger<CategoryController> logger, TestDBContext dbContext,ICategoryRepository categoryRepository)
        {
            _logger = logger;
            _dbContext = dbContext;
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ParentCategoryRepository parentCategoryRepository = new ParentCategoryRepository(_dbContext);
            ViewBag.ParentCategories = new SelectList(parentCategoryRepository.GetParentCategories(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            _categoryRepository.Create(category);
            return View();
        }

        public IActionResult _SubCategoryPartial(int parentCategoryId)
        {
            ParentCategoryRepository parentCategoryRepository = new ParentCategoryRepository(_dbContext);
            var parent = parentCategoryRepository.GetParentCategory(parentCategoryId);

            if (parent.Category != null && parent.Category.Count > 0)
            {
                SelectList model = new SelectList(parent.Category, "Id", "Name");
                return PartialView(model);
            }
            else
                return PartialView();

        }
    }
}