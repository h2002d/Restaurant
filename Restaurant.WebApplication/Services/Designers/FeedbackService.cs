using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Repository.Designers;
using Restaurant.WebApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Services.Designers
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IFeedbackRepository _feedbackRepository;

        public FeedbackService(IFeedbackRepository designerRepository)
        {
            _feedbackRepository = designerRepository;
        }
        public List<Feedback> GetFeedbacks()
        {
            return _feedbackRepository.GetFeedbacks();
        }
        public Feedback GetFeedback(int feedbackId)
        {
            return _feedbackRepository.GetFeedback(feedbackId);
        }

        public void Delete(int feedbackId)
        {
            var feedback = GetFeedback(feedbackId);
            _feedbackRepository.Delete(feedback);
        }

        public void Create(Feedback feedback)
        {
            _feedbackRepository.Create(feedback);
        }
    }
}
