using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.SharePoint.WebControls;
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
        private readonly IExerciseService exersiceService;
        private readonly ITeacherService teacherService;
        public MaterialController(IMaterialService _materialService,
            ILessonService _lessonService,
            IExerciseService _exersiceService,
            ITeacherService _teacherService)
        {
            materialService = _materialService;
            lessonService = _lessonService;
            exersiceService = _exersiceService;
            teacherService = _teacherService;
        }

        [HttpGet]
        public async Task<IActionResult> AddMaterialToLesson(int id)
        {
            var sectionId = await lessonService.GetSectionCurricularIdByLessonId(id);

            var model = new MaterialFormViewModel
            {
                LessonId = id,
                SectionOfCurricularId = sectionId
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddMaterialToLesson(MaterialFormViewModel model)
        {
            var userId = this.User.Id();

            await materialService.ConvertPresentationToPdf(model.FileInfo, userId, model.LessonId);

            if (model.Content != null)
            {
                await lessonService.SetContentToLesson(model.Content, model.LessonId);
            }

            RouteValueDictionary RouteInfo = new RouteValueDictionary();
            RouteInfo.Add("id", model.LessonId);

            return RedirectToAction("Index", "Lesson", RouteInfo);
        }

        [HttpGet]
        public async Task<IActionResult> AddMaterialToExercise(int id)
        {
            var sectionId = await lessonService.GetSectionCurricularIdByLessonId(id);

            var model = new MaterialFormViewModel
            {
                LessonId = id,
                SectionOfCurricularId = sectionId
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddMaterialToExercise(MaterialFormViewModel model)
        {
            var userId = this.User.Id();

            if (model.Content != null)
            {
                await exersiceService.SetContentToExercise(model.Content, model.LessonId);
            }

            await materialService.ConvertWordDocumentsToPdf(model.Documents, userId, model.LessonId, true);


            RouteValueDictionary RouteInfo = new RouteValueDictionary();
            RouteInfo.Add("id", model.LessonId);

            return RedirectToAction("Index", "Exercise", RouteInfo);
        }


        [HttpGet]
        public async Task<IActionResult> AddMaterialToLessonByTeacher(int id)
        {
            var sectionId = await lessonService.GetSectionCurricularIdByLessonId(id);

            var model = new MaterialFormViewModel
            {
                LessonId = id,
                SectionOfCurricularId = sectionId
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddMaterialToLessonByTeacher(MaterialFormViewModel model)
        {
            var userId = this.User.Id();

            byte[] fileBytes = null;

            if (model.FileInfo.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    model.FileInfo.CopyTo(ms);
                    fileBytes = ms.ToArray();
                    // act on the Base64 data
                }
            }

            await materialService.ZipUpload(fileBytes, userId, model.LessonId, false);

            RouteValueDictionary RouteInfo = new RouteValueDictionary();
            RouteInfo.Add("id", model.LessonId);

            return RedirectToAction("Index", "Lesson", RouteInfo);
        }

        [HttpGet]
        public async Task<IActionResult> AddMaterialForExerciseByTeacher(int id)
        {
            var sectionId = await lessonService.GetSectionCurricularIdByLessonId(id);

            var model = new MaterialFormViewModel
            {
                LessonId = id,
                SectionOfCurricularId = sectionId
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddMaterialForExerciseByTeacher(MaterialFormViewModel model)
        {
            var userId = this.User.Id();

            byte[] fileBytes = null;

            if (model.FileInfo.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    model.FileInfo.CopyTo(ms);
                    fileBytes = ms.ToArray();
                    // act on the Base64 data
                }
            }

            await materialService.ZipUpload(fileBytes, userId, model.LessonId, true);

            RouteValueDictionary RouteInfo = new RouteValueDictionary();
            RouteInfo.Add("id", model.LessonId);

            return RedirectToAction("Index", "Lesson", RouteInfo);
        }


        [HttpPost]
        public async Task<IActionResult> DeleteMaterialFromLesson(int id)
        {
            var lessonId = await lessonService.GetLessonByMaterialId(id);
            await materialService.DeleteMaterial(id, false);

            RouteValueDictionary RouteInfo = new RouteValueDictionary();
            RouteInfo.Add("id", lessonId);

            return RedirectToAction("Index", "Exercise", RouteInfo);
        }
    }
}
