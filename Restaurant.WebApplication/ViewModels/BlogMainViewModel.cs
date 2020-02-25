using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.ViewModels
{
    public class BlogMainViewModel : ViewModelBase
    {
        public List<Blog> Blogs { get; set; }
        public int PageCount{ get; set; }
    }
}
