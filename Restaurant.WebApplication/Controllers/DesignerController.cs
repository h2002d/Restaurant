using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Restaurant.WebApplication.Helpers;
using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Services.Designer;
using Restaurant.WebApplication.ViewModels;

namespace Restaurant.WebApplication.Controllers
{
    public class DesignerController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISliderService _sliderService;
        private IHostingEnvironment _hostingEnvironment;
        public DesignerController(IMapper mapper, ISliderService sliderService, IHostingEnvironment hostingEnvironment)
        {
            _mapper = mapper;
            _sliderService = sliderService;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult SlidersAll()
        {
            var sliders = _sliderService.GetSliders();
            var model=new SliderMainViewModel();
            model.Sliders = sliders;
            return View(model);
        }

        public IActionResult CreateSlider(int id)
        {
            var slider = _sliderService.GetSlider(id);
            return View(_mapper.Map<SliderViewModel>(slider));
        }

        [HttpPost]
        public IActionResult CreateSlider(SliderViewModel slider)
        {
            SliderImageHelper helper = new SliderImageHelper(_hostingEnvironment);
            slider.SliderImagePath = helper.SaveSliderImageToPath(slider.SliderImageFile)?? slider.SliderImagePath;
            slider.Background1Path = helper.SaveSliderImageToPath(slider.Background1File)?? slider.Background1Path;
            slider.Background2Path = helper.SaveSliderImageToPath(slider.Background2File) ?? slider.Background2Path;
            var sliderNew = _sliderService.Create(_mapper.Map<Slider>(slider));
            return RedirectToAction("CreateSlider", new { id = sliderNew.Id });
        }

        public IActionResult DeleteSlider(int id)
        {
            var slider = _sliderService.GetSlider(id);
            _sliderService.Delete(slider);
            return RedirectToAction("SlidersAll");
        }

    }
}