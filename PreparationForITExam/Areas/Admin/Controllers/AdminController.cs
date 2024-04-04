using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Admin;
using PreparationForITExam.Core.Services;

namespace PreparationForITExam.Areas.Admin.Controllers
{
    public class AdminController : BaseController
    {
        private readonly IUserService userService;
        private readonly IStudentService studentService;
        private readonly ITeacherService teacherService;
        private readonly IMonUserService monUserService;
        public AdminController(IUserService _userService,
            IStudentService _studentService,
            ITeacherService _teacherService,
            IMonUserService _monUserService)
        {
            userService = _userService;
            studentService = _studentService;
            teacherService = _teacherService;
            monUserService = _monUserService;
        }

        public async Task<IActionResult> Index(int id)
        {
            var model = new AdminViewModel();

            model.Users = await userService.GetAllUsers(id);
            var count = await userService.GetAllUsersCount();

            TempData["pages"] = count % 9 == 0 ? count / 9 : (count / 9) + 1; ;
            TempData["curr"] = id == 0 ? 1 : id;

            return View(model);
        }

        //see if it works!!!!!!!!!
        [HttpPost]
        public async Task<IActionResult> Index(AdminViewModel model)
        {
            var filter = model.Filtration;

            if (filter == 0) // All
            {
                model.Users = await userService.GetAllUsers(0);
            }
            else if (filter == 1) // Students
            {
                model.Users = await studentService.GetAllStudents(0);
            }
            else if (filter == 2) // Teachers
            {
                model.Users = await teacherService.GetAllTeachers(0);
            }
            else //MonUsers
            {
                model.Users = await monUserService.GetAllMonUsers(0);
            }

            return View(model);
        }

        public async Task<IActionResult> DeleteUser(string id)
        {
            await userService.DeleteUser(id);

            return RedirectToAction("Index");
        }
    }
}
