using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Question;
using PreparationForITExam.Core.Models.User;
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

        public QuestionService(IRepository _repo)
        {
            repo = _repo;
        }


        public async Task<List<QuestionViewModel>> GetAllLessonQuestionsByLessonId(int lessonId)
        {
            var questions = await repo.AllReadonly<LessonQuestion>()
                .Where(lq => lq.LessonId == lessonId)
                .Where(lq => lq.IsActive == true)
                .Select(lq => new QuestionViewModel
                {
                    Id = lq.Id,
                    UserInfo = new UserModel
                    {
                        Id = lq.UserId,
                        Name = lq.User.FirstName + " " + lq.User.LastName,
                        ProfilePictureUrl = lq.User.ProfilePictureUrl,
                        Role = lq.User.RoleName
                    }
                })
                .ToListAsync();

            return questions;
        }
    }
}
