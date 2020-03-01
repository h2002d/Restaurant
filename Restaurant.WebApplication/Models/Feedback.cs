using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
    }
}
