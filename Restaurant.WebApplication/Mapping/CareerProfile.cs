using AutoMapper;
using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Mapping
{
    public class CareerProfile : Profile
    {
        public CareerProfile()
        {
            CreateMap<Careers, CareerViewModel>();
            CreateMap<CareerViewModel, Careers>();
        }
    }
}
