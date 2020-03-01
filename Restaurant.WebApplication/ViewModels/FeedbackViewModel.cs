using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.ViewModels
{
    public class FeedbackViewModel : ViewModelBase
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public IFormFile Image { get; set; }
    }
}
