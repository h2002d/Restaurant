using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.ViewModels
{
    public class DesignerViewModel : ViewModelBase
    {
        public int Id { get; set; }
        public string AboutUsContent { get; set; }
        public string ContactUsContent { get; set; }
    }
}
