using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Services.Designers
{
    public interface IDesignerService
    {
        Designer GetDesigner();
        Designer Update(Designer designer);

    }
}
