using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Repository;

namespace Restaurant.WebApplication.Controllers
{
    public class ParentCategoryController : Controller
    {
        private TestDBContext _dbContext;
        private IParentCategoryRepository _categoryRepository;
        private readonly ILogger<ParentCategoryController> _logger;
        public ParentCategoryController(ILogger<ParentCategoryController> logger, TestDBContext dbContext,IParentCategoryRepository categoryRepository)
        {
            _logger = logger;
            _dbContext = dbContext;
            _categoryRepository = categoryRepository;
        }

        //must show all subcategories
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Create(ParentCategory parentCategory)
        //{
        //    _categoryRepository.Create(parentCategory);
        //    return View();
        //}
    }
}