using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.ViewModels
{
    public class CareerMainViewModel : ViewModelBase
    {
        public List<Careers> Careers { get; set; }
        public CareerMainViewModel()
        {
            Careers = new List<Careers>();
        }
    }
}
