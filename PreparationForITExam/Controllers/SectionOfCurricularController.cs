using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.SectionOfCurricular;

namespace PreparationForITExam.Controllers
{
    public class SectionOfCurricularController : BaseController
    {
        private readonly ISectionOfCurricularService sectionOfCurricularService;
        private readonly ILessonService lessonService;
        private readonly IExerciseService exerciseService;

        public SectionOfCurricularController(
            ISectionOfCurricularService _sectionOfCurricularService,
            ILessonService _lessonService,
            IExerciseService _exerciseService)
        {
            sectionOfCurricularService = _sectionOfCurricularService;
            lessonService = _lessonService;
            exerciseService = _exerciseService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index(int id)
        {
            SectionLessonViewModel model = new SectionLessonViewModel();

            model.Lessons = await lessonService.AllLessonsBySectionOfCurricularId(id);
            model.Exercises = await exerciseService.GetAllExercisesBySectionOfCurricularId(id);
            var list= await sectionOfCurricularService.GetTitleAndModuleOfSectionOfCurricularById(id);
            model.Title = list[0];
            model.Module = list[1];
            model.Id= id;

            return View(model);
        }
    }
}
