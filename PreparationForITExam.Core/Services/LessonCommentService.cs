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
    public class LessonCommentService : ILessonCommentService
    {
        private readonly IRepository repo;

        public LessonCommentService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task CreateLessonComment(LessonCommentFormViewModel model)
        {
            LessonComment comment = new LessonComment()
            {
                Title = model.Title,
                Content = model.Content,
                LessonId = model.LessonId,
                UserId = model.UserId,
                Url = model.Url
            };

            await repo.AddAsync(comment);
            await repo.SaveChangesAsync();
        }

        public async Task<List<LessonCommentViewModel>> GetAllLessonCommentsByLessonId(int lessonId)
        {
            var comments = await repo.AllReadonly<LessonComment>()
                .Where(lq => lq.LessonId == lessonId)
                .Where(lq => lq.IsActive == true)
                .Select(lq => new LessonCommentViewModel
                {
                    Id = lq.Id,
                    UserInfo = new UserModel
                    {
                        Id = lq.UserId,
                        Name = lq.User.FirstName + " " + lq.User.LastName,
                        ProfilePictureUrl = lq.User.ProfilePictureUrl,
                        Role = lq.User.RoleName
                    },
                    Content= lq.Content,
                    Title= lq.Title,
                    Url=lq.Url,
                    CreatedOn = lq.CreatedOn.ToString("yyyy-M-d"),

                })
                .ToListAsync();

            return comments;
        }
    }
}
