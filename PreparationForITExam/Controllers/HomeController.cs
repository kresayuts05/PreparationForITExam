using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Constants;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Home;
using PreparationForITExam.Core.Models.Review;
using PreparationForITExam.Core.Services;
using PreparationForITExam.Extensions;
using PreparationForITExam.Models;
using System.Diagnostics;

namespace PreparationForITExam.Controllers
{
    public class HomeController : BaseController
    {
        private readonly INewsService newsService;
        private readonly IReviewService reviewService;

        public HomeController(
            INewsService _newsService,
            IReviewService _reviewService)
        {
            newsService = _newsService;
            reviewService = _reviewService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            if (User.IsInRole(RoleConstants.Administrator))
            {
                return RedirectToAction("Index", "Admin", new { area = "Admin" });
            }

            var news = await newsService.GetAllNews();
            var reviews = await reviewService.GetAllReviews();

            HomeViewModel model = new HomeViewModel();
            model.News = news;
            model.Reviews = reviews;

            return View(model);
        }

        [HttpGet]
        public IActionResult Contacts()
        {
            var model = new ReviewViewModel();
            model.UserId = this.User.Id();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Contacts(ReviewViewModel model)
        {
            await reviewService.AddReview(model);

            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}