using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Comment;
using PreparationForITExam.Core.Models.Post;
using PreparationForITExam.Core.Services;
using PreparationForITExam.Extensions;

namespace PreparationForITExam.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService postService;
        private readonly ICommentService commentService;

        public PostController(
            IPostService _postService,
            ICommentService _commentService)
        {
            postService = _postService;
            commentService = _commentService;
        }

        public async Task<IActionResult> Index(int id)
        {
            var model = await postService.GetAllPosts(id);
            var count = await postService.GetPostCount();

            TempData["pages"] = count % 9 == 0 ? count / 9 : (count / 9) + 1; ;
            TempData["curr"] = id == 0 ? 1 : id;

            return View(model);
        }

        [HttpGet] 
        public async Task<IActionResult> GetOnlyPosts(int id)
        {
            var model = await postService.GetOnlyPosts(id);
            var count = await postService.GetOnlyPostsCount();

            TempData["pages"] = count % 9 == 0 ? count / 9 : (count / 9) + 1; ;
            TempData["curr"] = id == 0 ? 1 : id;

            return View("Index", model);
        }

        [HttpGet]
        public async Task<IActionResult> GetOnlyQuestions(int id)
        {
            var model = await postService.GetOnlyQuestions(id);
            var count = await postService.GetOnlyQuestionsCount();

            TempData["pages"] = count % 9 == 0 ? count / 9 : (count / 9) + 1; ;
            TempData["curr"] = id == 0 ? 1 : id;

            return View("Index", model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new PostFormViewModel()
            {
                UserId = User.Id()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(PostFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await postService.Create(model, false);

            return RedirectToAction("Index", "Post");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await postService.GetPostInfo(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PostFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await postService.Edit(model);

            return RedirectToAction("Index", "Post");
        }

        [HttpPost]
        public async Task<IActionResult> AddQuestion(PostFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await postService.Create(model, true);

            return RedirectToAction("Index", "Post");
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id, string? currpage)
        {
            int p = 1;
            if (currpage != null)
            {
                p = int.Parse(currpage);
            }

            var model = await postService.GetPostDetails(id, p);
            var count = await commentService.CommentCount(id);

            TempData["commentsPages"] = count % 9 == 0 ? count / 9 : (count / 9) + 1; ;
            TempData["currCommentPage"] = p == 0 ? 1 : p;

            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = new PostViewModel
            {
                Id = id,
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(PostViewModel model)
        {
            await postService.Delete(model.Id);

            return RedirectToAction("Index", "Post");
        }
    }
}
