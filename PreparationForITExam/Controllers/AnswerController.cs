using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Answer;
using PreparationForITExam.Core.Models.Material;
using PreparationForITExam.Core.Services;
using PreparationForITExam.Extensions;

namespace PreparationForITExam.Controllers
{
    public class AnswerController : BaseController
    {

        private readonly IAnswerService answerService;
        private readonly IMaterialService materialService;

        public AnswerController(
            IAnswerService _answerService, IMaterialService _materialService)
        {
            answerService = _answerService;
            materialService = _materialService;
        }

        [HttpGet]
        public IActionResult GetAllAnswers()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> SentMaterialToStudent(int id)
        {
            var userId = await materialService.GetUserIdByMaterialId(id, true);
            var exerciseId = await materialService.GetExerciseIdByMaterialId(id);

            var model = new AnswerFormViewModel
            {
                ExerciseMaterialId = id,
                UserId = userId,
                ExerciseId = exerciseId
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SentMaterialToStudent(AnswerFormViewModel model)
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

            await materialService.ZipUploadAnswer(fileBytes, userId, model.ExerciseMaterialId);

            RouteValueDictionary RouteInfo = new RouteValueDictionary();
            RouteInfo.Add("id", model.ExerciseId);

            return RedirectToAction("Index", "Exercise", RouteInfo);
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {

            var model = new AnswerModel
            {
                Id = id,
                UserId = User.Id()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMaterialFromExercise(MaterialModel model)
        {
            await answerService.Delete(model.Id);

            return RedirectToAction("Index", "Profile", User.Id());
        }

    }
}
