using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Services.Blogs;
using Restaurant.WebApplication.Services.Designers;
using Restaurant.WebApplication.ViewModels;

namespace Restaurant.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDesignerService _designerService;
        private readonly IFeedbackService _feedbackService;
        private readonly ISliderService _sliderService;
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        public HomeController(ILogger<HomeController> logger, IDesignerService designerService, IBlogService blogService, IFeedbackService feedbackService, ISliderService sliderService, IMapper mapper)
        {
            _logger = logger;
            _designerService = designerService;
            _mapper = mapper;
            _sliderService = sliderService;
            _feedbackService = feedbackService;
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            var indexModel = new IndexViewModel();
            indexModel.DesignerModel = _designerService.GetDesigner();
            indexModel.Sliders = _sliderService.GetSliders();
            indexModel.Feedbacks = _feedbackService.GetFeedbacks();
            indexModel.Blogs = _blogService.GetBlogs(1).Take(3).ToList();
            return View(indexModel);
        }

        public IActionResult Footer()
        {
            var indexModel = new IndexViewModel();
            indexModel.DesignerModel = _designerService.GetDesigner();
            return PartialView(indexModel);
        }

        public IActionResult Header()
        {
            var indexModel = new IndexViewModel();
            indexModel.DesignerModel = _designerService.GetDesigner();
            return PartialView(indexModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact()
        {
            var design = _designerService.GetDesigner();
            return View(_mapper.Map<DesignerViewModel>(design));
        }
        public IActionResult About()
        {
            var design = _designerService.GetDesigner();
            return View(_mapper.Map<DesignerViewModel>(design));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
