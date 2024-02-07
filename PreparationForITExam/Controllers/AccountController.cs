using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32.SafeHandles;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Account;
using PreparationForITExam.Infrastructure.Data.Entities;

namespace PreparationForITExam.Controllers
{

    public class AccountController : BaseController
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly IStudentService studentService;
        private readonly IImageService imageService;
        private readonly IUserService userService;
        private readonly ISchoolService schoolService;
        private readonly ITeacherService teacherService;

        public AccountController(
            UserManager<User> _userManager,
            SignInManager<User> _signInManager,
            IStudentService _studentService,
            IImageService _imageService,
            IUserService _userService,
            ISchoolService _schoolService,
            ITeacherService _teacherService)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            studentService = _studentService;
            imageService = _imageService;
            userService = _userService;
            schoolService = _schoolService;
            teacherService = _teacherService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Register()
        {
            var model = new RegisterViewModel();

            model.SchoolsCities = await schoolService.AllSchoolsWithCitiesAsDitionary();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> RegisterAsStudent(RegisterViewModel model)
        {
            int schoolId = 0;

            if (await userService.UserByEmailExists(model.Email))
            {
                ModelState.AddModelError(nameof(model.Email), "Вече съществува регистрация с този имейл!");
            }

            if (model.SchoolName != null)
            {
                if (model.City == null)
                {
                    ModelState.AddModelError(nameof(model.City), "Моля въведете града, в който е съответното учиище!");
                }

                schoolId = await schoolService.GetSchoolByNameAndCity(model.SchoolName, model.City);

                if (schoolId == 0)
                {
                    ModelState.AddModelError(nameof(model.City), "Училището не е намерено! Моля опитайте отново!");
                }
            }

            if (!ModelState.IsValid)
            {
                return View("Register", model);
            }

            var user = new User()
            {
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.Email,
                PhoneNumber = model.PhoneNumber,
                City = model.City,
                RoleName = "Student"
            };

            var result = await userManager.CreateAsync(user, model.Password);

            await userManager.AddToRoleAsync(user, "Student");
            await studentService.Create(user.Id, schoolId);

            if (model.ProfilePicture != null)
            {
                user.ProfilePictureUrl = await this.imageService.UploadImage(model.ProfilePicture, "images", user);
                await userManager.UpdateAsync(user);
            }

            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, isPersistent: false);

                return RedirectToAction("Index", "Home");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }

            return View("Register", model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> RegisterAsTeacher(RegisterViewModel model)
        {
            int schoolId = 0;

            if (await userService.UserByEmailExists(model.Email))
            {
                ModelState.AddModelError(nameof(model.Email), "Вече съществува регистрация с този имейл!");
            }

            if (model.SchoolName != null)
            {
                if (model.City == null)
                {
                    ModelState.AddModelError(nameof(model.City), "Моля въведете града, в който е съответното учиище!");
                }

                schoolId = await schoolService.GetSchoolByNameAndCity(model.SchoolName, model.City);

                if (schoolId == 0)
                {
                    ModelState.AddModelError(nameof(model.City), "Училището не е намерено! Моля опитайте отново!");
                }
            }

            if (!ModelState.IsValid)
            {
                return View("Register", model);
            }

            var user = new User()
            {
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.Email,
                PhoneNumber = model.PhoneNumber,
                City = model.City,
                RoleName = "Teacher"
            };

            var result = await userManager.CreateAsync(user, model.Password);

            //await userManager.AddToRoleAsync(user, "Teacher");//need to be approved by admin
            await teacherService.Create(user.Id, model, schoolId);

            if (model.ProfilePicture != null)
            {
                user.ProfilePictureUrl = await this.imageService.UploadImage(model.ProfilePicture, "images", user);
                await userManager.UpdateAsync(user);
            }

            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, isPersistent: false);

                return RedirectToAction("Index", "Home");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }

            return View("Register", model);
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            var model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.FindByEmailAsync(model.Email);

            if (user != null)
            {
                if (user.IsActive)
                {

                    var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }

            ModelState.AddModelError("", "Invalid login");

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
