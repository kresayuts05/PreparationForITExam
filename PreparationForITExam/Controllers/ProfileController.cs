using Microsoft.AspNetCore.Mvc;

namespace PreparationForITExam.Controllers
{
    public class ProfileController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
