using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository.Designers
{
    public class SliderRepository : ISliderRepository
    {
        protected TestDBContext _applicationDbContext;
        public SliderRepository(TestDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Slider Create(Slider slider)
        {
            if (slider.Id == 0)
                _applicationDbContext.Sliders.Add(slider);
            else
                _applicationDbContext.Sliders.Update(slider);
            _applicationDbContext.SaveChanges();
            return slider;
        }

        public void Delete(Slider slider)
        {
            _applicationDbContext.Sliders.Remove(slider);
            _applicationDbContext.SaveChanges();
        }

        public Slider GetSlider(int id)
        {
            return _applicationDbContext.Sliders.Find(id);
        }

        public List<Slider> GetSliders()
        {
            return _applicationDbContext.Sliders.ToList();
        }
    }
}
