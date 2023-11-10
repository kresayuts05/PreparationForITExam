﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Infrastructure.Data.Entities;
using PreparationForITExam.Models.Account;

namespace PreparationForITExam.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly IStudentService studentService;
        private readonly IImageService imageService;
        private readonly IUserService userService;

        public AccountController(
            UserManager<User> _userManager,
            SignInManager<User> _signInManager,
            IStudentService _studentService,
            IImageService _imageService,
            IUserService _userService)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            studentService = _studentService;
            imageService = _imageService;
            userService = _userService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            var model = new RegisterViewModel();

            return View(model);
        }

        //[HttpPost]
        //[AllowAnonymous]
        //public async Task<IActionResult> Register(RegisterViewModel model)
        //{
        //    if (await userService.UserByEmailExists(model.Email))
        //    {
        //        ModelState.AddModelError(nameof(model.Email), "There is already a registration with this email!");
        //    }

        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }

        //    var user = new User()
        //    {
        //        Email = model.Email,
        //        FirstName = model.FirstName,
        //        LastName = model.LastName,
        //        UserName = model.Email,
        //        PhoneNumber = model.PhoneNumber,
        //        Address = model.Address,
        //        City = model.City,
        //        Country = model.Country
        //    };

        //    var result = await userManager.CreateAsync(user, model.Password);

        //    await userManager.AddToRoleAsync(user, "Client");
        //    await clientService.Create(user.Id);

        //    user.ProfilePictureUrl = await this.imageService.UploadImage(model.ProfilePicture, "images", user);
        //    await userManager.UpdateAsync(user);

        //    if (result.Succeeded)
        //    {
        //        await signInManager.SignInAsync(user, isPersistent: false);

        //        return RedirectToAction("Index", "Home");
        //    }

        //    foreach (var item in result.Errors)
        //    {
        //        ModelState.AddModelError("", item.Description);
        //    }

        //    return View(model);
        //}

        //[HttpGet]
        //[AllowAnonymous]
        //public IActionResult Login()
        //{
        //    var model = new LoginViewModel();

        //    return View(model);
        //}

        //[HttpPost]
        //[AllowAnonymous]
        //public async Task<IActionResult> Login(LoginViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }

        //    var user = await userManager.FindByEmailAsync(model.Email);

        //    if (user != null)
        //    {
        //        if (user.IsActive)
        //        {

        //            var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

        //            if (result.Succeeded)
        //            {
        //                return RedirectToAction("Index", "Home");
        //            }
        //        }
        //    }

        //    ModelState.AddModelError("", "Invalid login");

        //    return View(model);
        //}

        //public async Task<IActionResult> Logout()
        //{
        //    await signInManager.SignOutAsync();

        //    return RedirectToAction("Index", "Home");
        //}
    }
}
