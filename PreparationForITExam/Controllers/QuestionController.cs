using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Question;
using PreparationForITExam.Core.Services;

namespace PreparationForITExam.Controllers
{
    public class QuestionController : BaseController
    {
        private readonly IQuestionService questionService;
        public QuestionController(IQuestionService _questionService)
        {
            questionService = _questionService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(QuestionFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await questionService.Create(model);

            
        }
    }
}
