using Microsoft.AspNetCore.Mvc;

namespace PreparationForITExam.Controllers
{
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
