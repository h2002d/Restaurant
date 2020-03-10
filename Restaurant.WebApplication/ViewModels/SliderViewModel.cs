using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.ViewModels
{
    public class SliderViewModel : ViewModelBase
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Описание")]
        public string Description { get; set; }
        [DisplayName("Главная картинка (450x280)")]
        public string SliderImagePath { get; set; }
        [DisplayName("Обложка (1920x700)")]
        public string Background1Path { get; set; }
        public string Background2Path { get; set; }
        public IFormFile SliderImageFile { get; set; }
        public IFormFile Background1File { get; set; }
        public IFormFile Background2File { get; set; }

        [DisplayName("Ссылка")]
        public string ShopNowURL { get; set; }
    }
}
