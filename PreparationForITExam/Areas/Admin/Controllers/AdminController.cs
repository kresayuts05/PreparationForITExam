using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Account;
using PreparationForITExam.Core.Models.Admin;
using PreparationForITExam.Core.Models.MonUser;
using PreparationForITExam.Core.Services;
using PreparationForITExam.Infrastructure.Data.Entities;

namespace PreparationForITExam.Areas.Admin.Controllers
{
    public class AdminController : BaseController
    {
        private readonly IUserService userService;
        private readonly IStudentService studentService;
        private readonly ITeacherService teacherService;
        private readonly IMonUserService monUserService;
        private readonly ISchoolService schoolService;
        private readonly IImageService imageService;
        private readonly UserManager<User> userManager;
        public AdminController(IUserService _userService,
            IStudentService _studentService,
            ITeacherService _teacherService,
            IMonUserService _monUserService,
            UserManager<User> _userManager,
            ISchoolService _schoolService,
            IImageService _imageService)
        {
            userService = _userService;
            studentService = _studentService;
            teacherService = _teacherService;
            monUserService = _monUserService;
            this.userManager = _userManager;
            schoolService = _schoolService;
            imageService = _imageService;
        }

        public async Task<IActionResult> Index(int id)
        {
            var model = new AdminViewModel();

            model.Users = await userService.GetAllUsers(id);
            var count = await userService.GetAllUsersCount();

            model.Teachers = await teacherService.GetAllTeachersWithStatusWaiting();

            TempData["pages"] = count % 9 == 0 ? count / 9 : (count / 9) + 1; ;
            TempData["curr"] = id == 0 ? 1 : id;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(AdminViewModel model)
        {
            var filter = model.Filtration;

            if (filter == 0) // All
            {
                model.Users = await userService.GetAllUsers(0);
                var count = await userService.GetAllUsersCount();

                model.Teachers = await teacherService.GetAllTeachersWithStatusWaiting();

                TempData["pages"] = count % 9 == 0 ? count / 9 : (count / 9) + 1; ;
                TempData["curr"] = 0;
            }
            else if (filter == 1) // Students
            {
                model.Users = await studentService.GetAllStudents();
            }
            else if (filter == 2) // Teachers
            {
                model.Users = await teacherService.GetAllTeachers();
            }
            else //MonUsers
            {
                model.Users = await monUserService.GetAllMonUsers();
            }

            model.Teachers = await teacherService.GetAllTeachersWithStatusWaiting();

            return View(model);
        }

        public async Task<IActionResult> DeleteUser(string id)
        {
            await userService.DeleteUser(id);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> GiveRoleToTeacher(string id)
        {
            await userService.GiveRoleToTeacher(id);
            await teacherService.ApproveTeacher(id);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeclineTeacherRole(int id)
        {
            await teacherService.DeclineTeacherRole(id);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> CreateMonUser()
        {
            var model = new MonUserViewModel();

            model.SchoolsCities = await schoolService.AllSchoolsWithCitiesAsDitionary();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMonUser(MonUserViewModel model)
        {
            if (await userService.UserByEmailExists(model.Email))
            {
                ModelState.AddModelError(nameof(model.Email), "Вече съществува регистрация с този имейл!");
            }

            if (model.City == null)
            {
                ModelState.AddModelError(nameof(model.City), "Моля въведете град!");
            }

            if (!ModelState.IsValid)
            {
                return View("CreateMonUser", model);
            }

            var user = new User()
            {
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.Email,
                PhoneNumber = model.PhoneNumber,
                City = model.City,
                AboutMe = model.AboutMe,
                RoleName = "MonUser"
            };

            var result = await userManager.CreateAsync(user, model.Password);

            await userManager.AddToRoleAsync(user, "MonUser");
            await monUserService.Create(user.Id);

            if (model.ProfilePicture != null)
            {
                user.ProfilePictureUrl = await this.imageService.UploadImage(model.ProfilePicture, "images", user);
                await userManager.UpdateAsync(user);
            }

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Admin");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }

            return View("CreateMonUser", model);
        }
    }
}
