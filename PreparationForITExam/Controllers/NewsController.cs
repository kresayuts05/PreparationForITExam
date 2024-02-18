using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.News;
using PreparationForITExam.Core.Services;
using PreparationForITExam.Extensions;

namespace PreparationForITExam.Controllers
{
    public class NewsController : BaseController
    {

        private readonly INewsService newsService;

        public NewsController(
            INewsService _newsService)
        {
            newsService = _newsService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new NewsFormViewModel();
            model.UserId = this.User.Id();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(NewsFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await newsService.AddNews(model);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await newsService.GetNewsDetails(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(NewsFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await newsService.Edit(model);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var model = new NewsFormViewModel();
            model.Id = id;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(NewsFormViewModel model)
        {
            await newsService.Delete(model.Id);

            return RedirectToAction("Index", "Home");
        }
    }
}
