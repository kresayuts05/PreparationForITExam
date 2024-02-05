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

            await materialService.ConvertPresentationToPdf(model.FileInfo, userId, 1);

            return View();
        }
    }
}
