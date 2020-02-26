using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository.Designers
{
    public class DesignerRepository : IDesignerRepository
    {
        protected TestDBContext _applicationDbContext;

        public DesignerRepository(TestDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Designer GetDesigner()
        {
            return _applicationDbContext.Designer.FirstOrDefault();
        }

        public Designer Update(Designer designer)
        {
            _applicationDbContext.Designer.RemoveRange(_applicationDbContext.Designer);
            _applicationDbContext.Designer.Add(designer);
            _applicationDbContext.SaveChanges();
            return designer;
        }
    }
}
