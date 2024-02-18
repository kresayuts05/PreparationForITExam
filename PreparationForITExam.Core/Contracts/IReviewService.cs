using PreparationForITExam.Core.Models.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface IReviewService
    {
        Task AddReview(ReviewViewModel model);

        Task<List<ReviewViewModel>> GetAllReviews();
    }
}
