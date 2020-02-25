using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.ViewModels
{
    public class SliderViewModel : ViewModelBase
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public string SliderImagePath { get; set; }
        public string Background1Path { get; set; }
        public string Background2Path { get; set; }
        public IFormFile SliderImageFile { get; set; }
        public IFormFile Background1File { get; set; }
        public IFormFile Background2File { get; set; }
        public string ShopNowURL { get; set; }
    }
}
