using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Services;

namespace PreparationForITExam.Controllers
{
    public class AnswerController : BaseController
    {

        private readonly IAnswerService answerService;

        public AnswerController(
            IAnswerService _answerService)
        {
            answerService = _answerService;
        }

        [HttpGet]
        public IActionResult GetAllAnswers()
        {
            return View();
        }
    }
}
