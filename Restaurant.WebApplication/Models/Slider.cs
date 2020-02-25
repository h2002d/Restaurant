using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public string SliderImagePath { get; set; }
        public string Background1Path { get; set; }
        public string Background2Path { get; set; }
        public string ShopNowURL { get; set; }
    }
}
