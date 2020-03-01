using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository.Designers
{
    public interface IFeedbackRepository
    {
        List<Feedback> GetFeedbacks();
        Feedback GetFeedback(int feedbackId);
        void Delete(Feedback feedback);
        void Create(Feedback feedback);
    }
}
