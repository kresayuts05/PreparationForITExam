using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Test;
using PreparationForITExam.Core.Services;
using PreparationForITExam.Extensions;

namespace PreparationForITExam.Controllers
{
    public class TestController : BaseController
    {
        private readonly ITestService testService;
        private readonly ITestScoreService testScoreService;

        public TestController(
            ITestService _testService, 
            ITestScoreService _testScoreService)
        {
            testService = _testService;
            testScoreService = _testScoreService;
        }

        public async Task<IActionResult> Index()
        {
            TestViewModel model = new TestViewModel();

            model.TestScores = await testService.GetAllTestScores();

            return View(model);
        }

        public async Task<IActionResult> Test()
        {
            var model = await testService.GenerateTest();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Test(TestViewModel model)
        {
            await testScoreService.Create(model.Score, this.User.Id());
            
            return RedirectToAction("Index", "Test");
        }
    }
}
