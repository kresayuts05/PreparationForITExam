using Microsoft.AspNetCore.Mvc;

namespace PreparationForITExam.Areas.Admin.Controllers
{
    public class AdminController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
