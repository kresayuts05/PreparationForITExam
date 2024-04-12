using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Account;
using PreparationForITExam.Core.Models.Review;
using PreparationForITExam.Core.Models.User;
using PreparationForITExam.Core.Services;
using PreparationForITExam.Infrastructure.Data.Common;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Tests.UnitTests
{
    [TestFixture]
    public class ReviewServiceTestClass : UnitTestsBase
    {
        private IRepository repo;
        private IReviewService reviewService;

        [SetUp]
        public async Task Setup()
        {
            this.repo = new Repository(this.context);
            this.reviewService = new ReviewService(repo);
        }

        [Test]
        public async Task CreateTeacherShouldReturnCorectResult()
        {
            var review = new Review()
            {
                Id = 1,
                Stars = 5,
                Description = "test",
                UserId = "StudentTestId"
            };

            await repo.AddAsync(review);
            await repo.SaveChangesAsync();

            var reviewModel = new ReviewViewModel()
            {
                Id = 1,
                Stars = 5,
                Description = "test",
                UserId = "StudentTestId"
            };

            await reviewService.AddReview(reviewModel);

            var dbTeacher = await repo.GetByIdAsync<Review>(1);

            Assert.IsNotNull(dbTeacher);
            Assert.That(dbTeacher.UserId, Is.EqualTo("StudentTestId"));
            Assert.That(dbTeacher.User.Email, Is.EqualTo("student@gmail.com"));
            Assert.That(dbTeacher.Stars, Is.EqualTo(5));
            Assert.That(dbTeacher.Description, Is.EqualTo("test"));
        }

        [Test]
        public async Task AllTeachersShouldReturnCorrectCollection()
        {
            var dbTeachers = await repo.AllReadonly<Review>()
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

            List<ReviewViewModel> teachers = (List<ReviewViewModel>)await reviewService.GetAllReviews();

            for (int i = 0; i < teachers.Count; i++)
            {
                Assert.AreEqual(dbTeachers[i].Id, teachers[i].Id);
            }
        }
    }
}
