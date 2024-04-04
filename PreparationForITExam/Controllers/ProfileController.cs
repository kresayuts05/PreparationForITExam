using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Constants;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Services;
using PreparationForITExam.Extensions;

namespace PreparationForITExam.Controllers
{
    public class ProfileController : BaseController
    {
        private readonly IUserService userService;
        private readonly IMaterialService materialService;
        private readonly IAnswerService answerService;
        private readonly IPostService postService;
        private readonly ICommentService commentService;

        public ProfileController(
            IUserService _userService,
            IMaterialService _materialService,
            IAnswerService _answerService,
            IPostService _postService,
            ICommentService _commentService)
        {
            userService = _userService;
            materialService = _materialService;
            answerService = _answerService;
            postService = _postService;
            commentService = _commentService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string id)//make it work
        {
            var model = await userService.GetUserInfo(id);

            model.MaterialsInExercise = await materialService.GetAllMaterialsForExerciseByUserId(id);
            model.MaterialsInLessons = await materialService.GetAllMaterialsForLessonByUserId(id);
            if (User.IsInRole(RoleConstants.Teacher))
            {
                model.Answers = await answerService.GetAnswersByUserId(id);
            }
            else
            {
                model.Answers = new List<Core.Models.Answer.AnswerModel>();
                foreach (var item in model.MaterialsInExercise)
                {
                    var info = await answerService.GetAnswersByMaterialId(item.Id);
                    model.Answers.AddRange(info);

                }
            }
            model.PostsUrls = await postService.GetAllPostsUrlsByUserId(id);
            model.QuestionsUrls = await postService.GetAllQuestionsUrlsByUserId(id);

            model.Comments = await commentService.CommentCountByUserId(id);

            model.Materials = (model.MaterialsInLessons == null ? 0 : model.MaterialsInLessons.Count) + (model.MaterialsInExercise == null ? 0 : model.MaterialsInExercise.Count);
            model.Questions = model.QuestionsUrls == null ? 0 : model.QuestionsUrls.Count;
            model.Posts = model.PostsUrls == null ? 0 : model.PostsUrls.Count;

            return View(model);
        }
    }
}
