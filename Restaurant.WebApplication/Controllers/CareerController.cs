using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Repository;
using Restaurant.WebApplication.ViewModels;

namespace Restaurant.WebApplication.Controllers
{
    public class CareerController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private TestDBContext _dbContext;
        private ICareerRepository _careerRepository;
        private IHostingEnvironment _hostingEnvironment;
        private readonly IMapper _mapper;
        public CareerController(ILogger<ProductController> logger, TestDBContext dbContext, IMapper mapper, IHostingEnvironment hostingEnvironment, ICareerRepository careerRepository)
        {
            _logger = logger;
            _dbContext = dbContext;
            _hostingEnvironment = hostingEnvironment;
            _careerRepository = careerRepository;
            _mapper = mapper;
        }
        public IActionResult Index(int careerId)
        {
            //
            //get the carrer if career is nul return the main page

            if (careerId == 0)
            {
                var career = _careerRepository.GetCareers();
                var model = new CareerMainViewModel();
                model.Careers = career;
                return View(model);
            }
            else
            {
                var career = _careerRepository.GetCareer(careerId);
                var model = new CareerDetailViewModel();
                model.Career = career;
                return View("CareerDetail", model);
            }

        }
        public IActionResult All()
        {
            var career = _careerRepository.GetCareers();
            var model = new CareerMainViewModel();
            model.Careers = career;
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Careers career)
        {
            try
            {
                var careerNew = _careerRepository.Create(career);

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(career);
            }
            return RedirectToAction("Create");
        }

        public IActionResult Edit(int Id)
        {
            var career = _careerRepository.GetCareer(Id);
            return View("Create", _mapper.Map<CareerViewModel>(career));
        }

        public IActionResult Delete(int Id)
        {
            var career = _careerRepository.GetCareer(Id);
            if (career != null)
                _careerRepository.Delete(career);

            return View("Create", career);
        }
    }
}