using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository.Designers
{
    public class FeedbackRepository : IFeedbackRepository
    {
        protected TestDBContext _applicationDbContext;

        public FeedbackRepository(TestDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Feedback GetFeedback(int feedbackId)
        {
            return _applicationDbContext.Feedbacks.Find(feedbackId);
        }

        public List<Feedback> GetFeedbacks()
        {
            return _applicationDbContext.Feedbacks.ToList();
        }
        public void Delete(Feedback feedback)
        {
            _applicationDbContext.Feedbacks.Remove(feedback);
            _applicationDbContext.SaveChanges();
        }

        public void Create(Feedback feedback)
        {
            if (feedback.Id == 0)
                _applicationDbContext.Feedbacks.Add(feedback);
            else
                _applicationDbContext.Feedbacks.Update(feedback);
            _applicationDbContext.SaveChanges();
        }
    }
}
