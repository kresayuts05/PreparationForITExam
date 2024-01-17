using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Infrastructure.Data.Entities;

namespace PreparationForITExam.Controllers
{
    public class CurricularController : Controller
    {
        private readonly ISectionOfCurricularService sectionOfCurricularService;

        public CurricularController(
            ISectionOfCurricularService _sectionOfCurricularService)
        {
            sectionOfCurricularService = _sectionOfCurricularService;
        }

        [HttpGet]
        public async  Task<IActionResult> Index()
        {
            var model = await sectionOfCurricularService.GetAllSectionsOfModule();

            return View(model);
        }
    }
}
