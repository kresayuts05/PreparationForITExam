using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Material;
using PreparationForITExam.Extensions;
using System;

namespace PreparationForITExam.Controllers
{
    public class MaterialController : BaseController
    {
        private readonly IMaterialService materialService;
        private readonly ILessonService lessonService;
        public MaterialController(IMaterialService _materialService,
            ILessonService _lessonService)
        {
            materialService = _materialService;
            lessonService = _lessonService;
        }

        [HttpGet]
        public async Task<IActionResult> Add(int id)
        {
            var sectionId = await lessonService.GetSectionCurricularIdByLessonId(id);

            var model = new MaterialFormViewModel
            {
                LessonId = id,
                SectionOfCurricularId= sectionId
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(MaterialFormViewModel model)
        {
            var userId = this.User.Id();

            await materialService.ConvertPresentationToPdf(model.FileInfo, userId, model.LessonId);

            if (model.Content != null)
            {
                await lessonService.SetContentToLesson(model.Content, model.LessonId);
            }

            if (model.Documents.Any())
            {
                await materialService.ConvertWordDocumentsToPdf(model.Documents, userId, model.LessonId);
            }

            RouteValueDictionary RouteInfo = new RouteValueDictionary();
            RouteInfo.Add("id", model.LessonId);

            return RedirectToAction("Index", "Lesson", RouteInfo);
            //  return RedirectToAction("Index", "SectionOfCurricular", model.SectionOfCurricularId);
        }
    }
}
