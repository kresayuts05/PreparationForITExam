using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Constants;
using PreparationForITExam.Models;
using System.Diagnostics;

namespace PreparationForITExam.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            if (User.IsInRole(RoleConstants.Administrator))
            {
                return RedirectToAction("Index", "Admin", new { area = "Admin" });
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}