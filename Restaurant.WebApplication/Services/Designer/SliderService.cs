using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Repository.Designers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Services.Designer
{
    public class SliderService : ISliderService
    {
        private readonly ISliderRepository _sliderRepository;

        public SliderService(ISliderRepository sliderRepository)
        {
            _sliderRepository = sliderRepository;
        }

        public Slider Create(Slider slider)
        {
            return _sliderRepository.Create(slider);
        }

        public void Delete(Slider slider)
        {
            _sliderRepository.Delete(slider);
        }

        public Slider GetSlider(int id)
        {
            return _sliderRepository.GetSlider(id);
        }

        public List<Slider> GetSliders()
        {
            return _sliderRepository.GetSliders();
        }
    }
}
