using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Question;
using PreparationForITExam.Infrastructure.Data.Common;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IRepository repo;
        private readonly IImageService imageService;
        private readonly IQuestionAnswerService questionAnswerService;
        private readonly IQuestionCategoryService questionCategoryService;

        public QuestionService(IRepository _repo,
            IImageService _imageService,
            IQuestionAnswerService _questionAnswerService,
            IQuestionCategoryService _questionCategoryService)
        {
            repo = _repo;
            imageService = _imageService;
            questionAnswerService = _questionAnswerService;
            questionCategoryService = _questionCategoryService;
        }
        public async Task Add(QuestionFormViewModel model)
        {
            Question question = new Question()
            {
                Description = model.Description,
                RightAnswer = model.RightAnswer,
                CategoryId = model.CategoryId,
                UserId = model.UserId,
            };

            await repo.AddAsync(question);
            await repo.SaveChangesAsync();

            await questionAnswerService.Add(model.RightAnswer, question.Id);
            await questionAnswerService.Add(model.Answer2, question.Id);
            await questionAnswerService.Add(model.Answer3, question.Id);
            await questionAnswerService.Add(model.Answer4, question.Id);

            if (model.Image != null)
            {
                question.Image = await imageService.UploadImageQuestion(model.Image, "questions", question.Id);
                await repo.SaveChangesAsync();
            }
        }

        public async Task<QuestionViewModel> GetRandomQuestionFromCategory(int categoryId)
        {
            var questionsIds = await questionCategoryService.GetQuestionsIdsCountByCategoryId(categoryId);

            if (questionsIds.Count > 0)
            {
                Random rnd = new Random();
                int rndIndex = rnd.Next(questionsIds.Count);

                int rndQuestionId = questionsIds[rndIndex];

                var question = await repo.AllReadonly<Question>()
                    .Where(q => q.Id == rndQuestionId)
                    .FirstOrDefaultAsync();

                var answers = await questionAnswerService.GetAnswersByQuestionId(rndQuestionId);

                var model = new QuestionViewModel
                {
                    Id = rndQuestionId,
                    Answers = answers,
                    RightAnswer = question.RightAnswer,
                    Description = question.Description,
                    Image = question.Image,
                };

                return model;
            }

            return null;
        }
    }
}
