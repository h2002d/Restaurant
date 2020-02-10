using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository
{
    public interface ICareerRepository
    {
        Careers Create(Careers product);
        void Delete(Careers product);
        Careers GetCareer(int careerId);
        List<Careers> GetCareers();
    }
}

