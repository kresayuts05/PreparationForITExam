using Microsoft.EntityFrameworkCore;
using Microsoft.SharePoint.Administration;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Review;
using PreparationForITExam.Infrastructure.Data.Common;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Services
{
    //This class contains all business logic for reviews.
    public class ReviewService: IReviewService
    {
        private readonly IRepository repo;

        public ReviewService(IRepository _repo)
        {
            repo = _repo;
        }

        //This method created review. 
        public async Task AddReview(ReviewViewModel model)
        {
            var review = new Review()
            {
                Stars = model.Stars,
                Description = model.Description,
                UserId = model.UserId
            };

            await repo.AddAsync(review);
            await repo.SaveChangesAsync();
        }

        //This method returns list of review view model. It is used to display all reviews in the home page
        public async Task<List<ReviewViewModel>> GetAllReviews()
        {
            var model = await repo.AllReadonly<Review>()
                .Where(r => r.IsActive)
                .Select(r => new ReviewViewModel
                {
                    Stars = r.Stars,
                    Description = r.Description,
                    UserId = r.UserId,
                    UserName = r.User.FirstName + " " + r.User.LastName,
                    UserProfileUrl = r.User.ProfilePictureUrl,
                    RoleName = r.User.RoleName
                })
                .ToListAsync();

            return model;
        }
    }
}
