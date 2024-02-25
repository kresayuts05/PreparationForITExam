using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Comment;
using PreparationForITExam.Core.Models.Material;
using PreparationForITExam.Core.Models.Post;
using PreparationForITExam.Core.Services;
using PreparationForITExam.Extensions;

namespace PreparationForITExam.Controllers
{
    public class CommentController : BaseController
    {
        private readonly ICommentService commentService;

        public CommentController(
            ICommentService _commentService)
        {
            commentService = _commentService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(PostViewModel model)
        {
            var commentModel = model.CommentModel;
            commentModel.UserId = this.User.Id();
            commentModel.PostId = model.Id;

            await commentService.Create(commentModel);


            RouteValueDictionary RouteInfo = new RouteValueDictionary();
            RouteInfo.Add("id", model.Id);

            return RedirectToAction("Details", "Post", RouteInfo);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var postId = await commentService.GetPostIdByCommentId(id);
            var model = new CommentViewModel
            {
                Id = id,
                PostId = postId
            };

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Delete(CommentViewModel model)
        {
            await commentService.Delete(model.Id);

            RouteValueDictionary RouteInfo = new RouteValueDictionary();
            RouteInfo.Add("id", model.PostId);

            return RedirectToAction("Details", "Post", RouteInfo);
        }
    }
}
