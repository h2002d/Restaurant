using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.ViewModels
{
    public class CareerViewModel : ViewModelBase
    {
        public int Id { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Контент")]
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
