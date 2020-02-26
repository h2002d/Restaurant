using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository.Designers
{
    public interface IDesignerRepository
    {
        Designer GetDesigner();
        Designer Update(Designer designer);
    }
}
