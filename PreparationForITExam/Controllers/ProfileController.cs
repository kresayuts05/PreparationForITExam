﻿using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> Index()
        {
            string userId = this.User.Id();
            var model = await userService.GetUserInfo(userId);

            model.MaterialsInExercise = await materialService.GetAllMaterialsForExerciseByUserId(userId);
            model.MaterialsInExercise = await materialService.GetAllMaterialsForLessonByUserId(userId);
            model.Answers = await answerService.GetAnswersByUserId(userId);
            model.PostsUrls = await postService.GetAllPostsUrlsByUserId(userId);
            model.QuestionsUrls = await postService.GetAllQuestionsUrlsByUserId(userId);

            model.Comments = await commentService.CommentCountByUserId(userId);

            model.Materials = (model.MaterialsInLessons == null ? 0 : model.MaterialsInLessons.Count) + (model.MaterialsInExercise == null ? 0 : model.MaterialsInExercise.Count);
            model.Questions = model.QuestionsUrls == null ? 0 : model.QuestionsUrls.Count;
            model.Posts = model.PostsUrls == null ? 0 : model.PostsUrls.Count;

            return View(model);
        }
    }
}
