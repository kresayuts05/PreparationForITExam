using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Account;
using PreparationForITExam.Infrastructure.Data.Common;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly IRepository repo;

        public TeacherService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task Create(string userId, RegisterViewModel model, int schoolId)
        {
            var teacher = new Teacher()
            {
                UserId = userId,
                Experience = model.Experience,
                Subject = model.Subject,
                SchoolId = schoolId
            };

            await repo.AddAsync(teacher);
            await repo.SaveChangesAsync();
        }

        public async  Task<int> GetTeacherIdByUserId(string id)
        {
            var teacher = await repo.All<Teacher>()
                .Where(t => t.UserId == id)
                .FirstOrDefaultAsync();

            return teacher.Id;
        }

    }
}
