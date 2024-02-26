using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Extensions;

namespace PreparationForITExam.Controllers
{
    public class ExerciseController : BaseController
    {
        private readonly IExerciseService exerciseService;
        private readonly IUserService userService;
        public ExerciseController(IExerciseService _exerciseService, IUserService _userService)
        {
            exerciseService = _exerciseService;
            userService = _userService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index(int id)
        {
            try
            {
                var model = await exerciseService.GetExerciseById(id);

                return View(model);
            }
            catch (Exception ex)
            {
                TempData["message"] = "Все още няма такова упражнение. Съжаляваме за неудобството!";

                return RedirectToAction("Index", "Curricular");
            }
        }
    }
}
