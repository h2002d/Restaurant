using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Services.Designers
{
    public interface IFeedbackService
    {
        List<Feedback> GetFeedbacks();
        Feedback GetFeedback(int feedbackId);
        void Delete(int feedbackId);
        void Create(Feedback feedback);
    }
}
