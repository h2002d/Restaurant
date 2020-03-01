using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.ViewModels
{
    public class IndexViewModel : ViewModelBase
    {
        public Designer DesignerModel { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Feedback> Feedbacks { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
