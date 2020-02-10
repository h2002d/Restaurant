using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository
{
    public interface IBlogRepository
    {
        Blog Create(Blog product);
        void Delete(Blog product);
        Blog GetBlog(int careerId);
    }
}
