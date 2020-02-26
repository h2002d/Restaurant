using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Services.Designers;
using Restaurant.WebApplication.ViewModels;

namespace Restaurant.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDesignerService _designerService;
        private readonly IMapper _mapper;
        public HomeController(ILogger<HomeController> logger, IDesignerService designerService, IMapper mapper)
        {
            _logger = logger;
            _designerService = designerService;
            _mapper = mapper;

        }

        public IActionResult Index()
        {
            return View(new IndexViewModel());
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
