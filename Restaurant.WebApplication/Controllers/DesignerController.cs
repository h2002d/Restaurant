using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Restaurant.WebApplication.Helpers;
using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Services.Designers;
using Restaurant.WebApplication.ViewModels;

namespace Restaurant.WebApplication.Controllers
{
    public class DesignerController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISliderService _sliderService;
        private readonly IDesignerService _designerService;
        private readonly IFeedbackService _feedbackService;
        private IHostingEnvironment _hostingEnvironment;
        public DesignerController(IMapper mapper, ISliderService sliderService, IHostingEnvironment hostingEnvironment, IFeedbackService feedbackService, IDesignerService designerService)
        {
            _mapper = mapper;
            _sliderService = sliderService;
            _designerService = designerService;
            _hostingEnvironment = hostingEnvironment;
            _feedbackService = feedbackService;
        }
        //need to implement page to open all the pages of designer
        public IActionResult Index()
        {
            return View(new ViewModelBase());
        }


        #region Slider
        public IActionResult SlidersAll()
        {
            var sliders = _sliderService.GetSliders();
            var model = new SliderMainViewModel();
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
            slider.SliderImagePath = helper.SaveSliderImageToPath(slider.SliderImageFile) ?? slider.SliderImagePath;
            slider.Background1Path = helper.SaveSliderImageToPath(slider.Background1File) ?? slider.Background1Path;
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
        #endregion

        #region Main designer

        public IActionResult Main()
        {
            var design = _designerService.GetDesigner();
            return View(_mapper.Map<DesignerViewModel>(design));
        }

        [HttpPost]
        public IActionResult Main(DesignerViewModel designerView)
        {
            var design = _designerService.Update(_mapper.Map<Designer>(designerView));
            return View(_mapper.Map<DesignerViewModel>(design));
        }

        #endregion

        #region Feedback
        public IActionResult FeedbackAll()
        {
            var feedbacks = _feedbackService.GetFeedbacks();
            var model = new FeedbackMainViewModel();
            model.Feedbacks = feedbacks;
            return View(model);
        }

        public IActionResult FeedbackCreate(int Id)
        {
            var feedbacks = _feedbackService.GetFeedback(Id);
            return View(_mapper.Map<FeedbackViewModel>(feedbacks));
        }

        public IActionResult FeedbackDelete(int Id)
        {
            _feedbackService.Delete(Id);
            return RedirectToAction("FeedbackAll");
        }

        [HttpPost]
        public IActionResult FeedbackCreate(FeedbackViewModel feedback)
        {
            if (feedback.Image != null)
            {
                var helper = new FeedbackImagesHelper(_hostingEnvironment);
                feedback.ImagePath = helper.SaveSliderImageToPath(feedback.Image);
            }
            _feedbackService.Create(_mapper.Map<Feedback>(feedback));
            return RedirectToAction("FeedbackAll");
        }
        #endregion
    }
}