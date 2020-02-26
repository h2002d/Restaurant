using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Repository.Designers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Services.Designers
{
    public class DesignerService : IDesignerService
    {
        private readonly IDesignerRepository _designerRepository;

        public DesignerService(IDesignerRepository designerRepository)
        {
            _designerRepository = designerRepository;
        }
        public Designer GetDesigner()
        {
            return _designerRepository.GetDesigner();
        }

        public Designer Update(Designer designer)
        {
            return _designerRepository.Update(designer);
        }
    }
}
