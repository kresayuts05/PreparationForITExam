using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Question;
using PreparationForITExam.Core.Models.Test;
using PreparationForITExam.Infrastructure.Data.Common;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Services
{
    public class TestService : ITestService
    {
        private readonly IRepository repo;
        private readonly IQuestionService questionService;

        public TestService(IRepository _repo,
            IQuestionService _questionService)
        {
            repo = _repo;
            questionService = _questionService;
        }

        public async Task<TestViewModel> GenerateTest()
        {
            var model = new TestViewModel();

            var question = new QuestionViewModel();

            for (int i = 1; i < 26; i++)
            {
                question = await questionService.GetRandomQuestionFromCategory(i);

                if (question != null)
                {
                    model.Questions.Add(question);
                }
            }

            return model;
        }

        public async Task<List<TestScoreViewModel>> GetAllTestScores()
        {
            var scores = await repo.AllReadonly<TestScore>()
                .OrderByDescending(s => s.Score)
                .Select(s => new TestScoreViewModel
                {
                    Score = s.Score,
                    Time = s.Time,
                    ProfilePicturUrl = s.User.ProfilePictureUrl,
                    UserName = s.User.FirstName + " " + s.User.LastName,
                    UserRole = s.User.RoleName
                })
                .ToListAsync();

            return scores;
        }
    }
}
