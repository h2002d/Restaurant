﻿using AutoMapper;
using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Mapping
{
    public class DesignerProfile : Profile
    {
        public DesignerProfile()
        {
            CreateMap<Designer, DesignerViewModel>();
            CreateMap<DesignerViewModel, Designer>();
        }
    }
}
