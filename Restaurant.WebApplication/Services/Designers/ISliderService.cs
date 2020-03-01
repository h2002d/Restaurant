using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Services.Designers
{
    public interface ISliderService
    {
        List<Slider> GetSliders();
        Slider GetSlider(int id);
        Slider Create(Slider slider);
        void Delete(Slider slider);
    }
}
