using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Material;
using PreparationForITExam.Extensions;

namespace PreparationForITExam.Controllers
{
    [Authorize]
    public class MaterialController : Controller
    {
        private readonly IMaterialService materialService;
        public MaterialController(IMaterialService _materialService)
        {
            materialService= _materialService;
        }

        [HttpPost]
        public async Task<ActionResult> Add(MaterialViewModel model)
        {
            var userId = this.User.Id();

            await using var memoryStream = new MemoryStream();
            await model.FileInfo.CopyToAsync(memoryStream);
            var r = memoryStream.ToArray();

            await materialService.ZipUpload(r, userId, model.LessonId);

            return View();
        }
    }
}
