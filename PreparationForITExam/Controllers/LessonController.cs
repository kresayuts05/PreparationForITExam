using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Services;
using PreparationForITExam.Extensions;

namespace PreparationForITExam.Controllers
{
    public class LessonController : BaseController
    {
        private readonly ILessonService lessonService;
        private readonly IUserService userService;
        public LessonController(ILessonService _lessonService, IUserService _userService)
        {
            lessonService = _lessonService;
            userService = _userService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index(int id)
        {
            try
            {
                var model = await lessonService.GetLessonById(id);

                if (User.Identity.IsAuthenticated)
                {
                    ViewBag.CurrUserName = await userService.UserNameById(this.User.Id());
                }

                return View(model);
            }
            catch (Exception ex)
            {
                TempData["message"] = "Все още няма такъв урок. Съжаляваме за неудобството!";
                return RedirectToAction("Index", "Curricular");
            }

        }
    }
}
