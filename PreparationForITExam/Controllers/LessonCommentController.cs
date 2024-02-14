using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Question;
using PreparationForITExam.Core.Services;

namespace PreparationForITExam.Controllers
{
    public class LessonCommentController : BaseController
    {
        private readonly ILessonCommentService lessonCommentService;
        public LessonCommentController(ILessonCommentService _questionService)
        {
            lessonCommentService = _questionService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(LessonCommentFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await lessonCommentService.CreateLessonComment(model);

            return Ok();

        }
    }
}
