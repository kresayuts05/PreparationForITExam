using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Post;
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
    }
}
