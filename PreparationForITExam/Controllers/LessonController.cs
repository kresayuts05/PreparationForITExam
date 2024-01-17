using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PreparationForITExam.Controllers
{
    [Authorize]
    public class LessonController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
