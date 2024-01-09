using Microsoft.AspNetCore.Mvc;

namespace PreparationForITExam.Controllers
{
    public class CurricularController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
