using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Question;
using PreparationForITExam.Core.Services;
using PreparationForITExam.Extensions;

namespace PreparationForITExam.Controllers
{
    public class QuestionController : BaseController
    {
        private readonly IQuestionService questionService;
        private readonly IQuestionCategoryService questionCategoryService;

        public QuestionController(
            IQuestionService _questionService,
            IQuestionCategoryService _questionCategoryService)
        {
            questionService = _questionService;
            questionCategoryService = _questionCategoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new QuestionFormViewModel();

            model.Categories = await questionCategoryService.GetAllCategories();
            model.UserId = this.User.Id();

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Add(QuestionFormViewModel model)
        {
            await questionService.Add(model);

            return RedirectToAction("Index", "Test");
        }
    }
}
