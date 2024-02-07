using Microsoft.AspNetCore.Mvc;

namespace PreparationForITExam.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
