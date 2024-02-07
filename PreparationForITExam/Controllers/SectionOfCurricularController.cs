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

        public SectionOfCurricularController(
            ISectionOfCurricularService _sectionOfCurricularService,
            ILessonService _lessonService)
        {
            sectionOfCurricularService = _sectionOfCurricularService;
            lessonService = _lessonService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index(int id)
        {
            SectionLessonViewModel model = new SectionLessonViewModel();

            model.Lessons = await lessonService.AllLessonsBySectionOfCurricularId(id);
            var list= await sectionOfCurricularService.GetTitleAndModuleOfSectionOfCurricularById(id);
            model.Title = list[0];
            model.Module = list[1];
            model.Id= id;

            return View(model);
        }
    }
}
