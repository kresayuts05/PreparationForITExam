using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Account;
using PreparationForITExam.Core.Models.Teacher;
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

        public async Task DeleteTeacher(string userId)
        {
            var teacher = await repo.All<Teacher>()
                .Where(t => t.UserId == userId)
                .FirstOrDefaultAsync();

            teacher.IsActive = false;

            await repo.SaveChangesAsync();
        }

        public async Task<List<UserModel>> GetAllTeachers(int page)
        {
            var model = await repo.AllReadonly<Teacher>()
                .Where(t => t.IsActive == true)
                .OrderByDescending(p => p.Id)
                .Skip(9 * ((int)(page == 0 ? 1 : page) - 1))
                .Take(9)
                .Select(t => new UserModel
                {
                    UserInRoleId = t.Id,
                    Id = t.UserId,
                    Name = t.User.FirstName + " " + t.User.LastName,
                    Role = "Teacher",
                    City = t.User.City,
                    SchoolName = t.School.Name,
                    ProfilePictureUrl = t.User.ProfilePictureUrl
                })
                .ToListAsync();

            return model;
        }

        public async Task<List<TeacherModel>> GetAllTeachersWithStatusWaiting()
        {
            var model = await repo.AllReadonly<Teacher>()
                 .Where(t => t.Status == "Waiting")
                 .Select(t => new TeacherModel
                 {
                     UserId = t.User.Id,
                     TeacherId = t.Id,
                     Name = t.User.FirstName + " " + t.User.LastName,
                     ProfilePictureUrl = t.User.ProfilePictureUrl,
                     Role = t.User.RoleName,
                     City = t.User.City,
                     SchoolName = t.School.Name,
                     Experience = t.Experience,
                     Subject = t.Subject
                 })
                 .ToListAsync();

            return model;
        }

        public async Task<int> GetTeacherIdByUserId(string id)
        {
            var teacher = await repo.All<Teacher>()
                .Where(t => t.UserId == id)
                .FirstOrDefaultAsync();

            return teacher.Id;
        }
    }
}
