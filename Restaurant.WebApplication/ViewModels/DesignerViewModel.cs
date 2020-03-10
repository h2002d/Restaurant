using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.ViewModels
{
    public class DesignerViewModel : ViewModelBase
    {
        public int Id { get; set; }
        [DisplayName("О нас")]
        public string AboutUsContent { get; set; }
        [DisplayName("Контакты")]
        public string ContactUsContent { get; set; }
        [DisplayName("Наша миссия")]
        public string OurMission { get; set; }
        [DisplayName("Телефон")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public string VkLink { get; set; }
        public string PinterestLink { get; set; }
        [DisplayName("Адресс")]
        public string Address { get; set; }
    }
}
