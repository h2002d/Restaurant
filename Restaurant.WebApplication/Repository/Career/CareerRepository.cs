using Microsoft.EntityFrameworkCore;
using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository
{
    public class CareerRepository : ICareerRepository
    {
        protected TestDBContext _applicationDbContext;
        public CareerRepository(TestDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public Careers Create(Careers career)
        {
            career.CreateDate = DateTime.Now;
            var localCareer = GetCareer(career.Id);

            if (localCareer != null)
            {
                _applicationDbContext.Entry(localCareer).State = EntityState.Detached;
                _applicationDbContext.Careers.Update(career);
            }
            else
                _applicationDbContext.Careers.Add(career);
            _applicationDbContext.SaveChanges();
            return career;
        }

        public void Delete(Careers career)
        {
            _applicationDbContext.Careers.Remove(career);
            _applicationDbContext.SaveChanges();
        }

        public Careers GetCareer(int careerId)
        {
            var career = _applicationDbContext.Careers.Find(careerId);
            return career;
        }
        public List<Careers> GetCareers()
        {
            try
            {
                List<Careers> careers = new List<Careers>();
                careers = _applicationDbContext.Careers.ToList();
                return careers;
            }
            catch
            {
                return null;
            }
        }
    }
}
