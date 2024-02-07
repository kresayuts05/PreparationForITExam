using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Services;

namespace PreparationForITExam.Controllers
{
    public class LessonController : BaseController
    {
        private readonly ILessonService lessonService;
        public LessonController(ILessonService _lessonService)
        {
            lessonService = _lessonService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index(int id)
        {
            var model = await lessonService.GetLessonById(id);

            return View(model);
        }
    }
}
