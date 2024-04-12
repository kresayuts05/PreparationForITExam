using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Exception;
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

        //This method changes teacher's status to approve. This allows the teacher to use the application
        public async Task ApproveTeacher(string id)
        {
            var teacher = await repo.All<Teacher>()
                .Where(t => t.UserId == id)
                .FirstOrDefaultAsync();

            if (teacher == null)
            {
                throw new NullReferenceException(GlobalExceptions.TeacherDoesNotExistExceptionMessage);
            }

            teacher.Status = "Approved";
            await repo.SaveChangesAsync();
        }

        //This method creates teachers. Makes an instance in the database which is connected with one user. 
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

        //This method declines teacher to be in a teacher role. It changes the status to dissaproved
        public async Task DeclineTeacherRole(int id)
        {
            var teacher = await repo.All<Teacher>()
                .Where(t => t.Id == id)
                .FirstOrDefaultAsync();

            if (teacher == null)
            {
                throw new NullReferenceException(GlobalExceptions.TeacherDoesNotExistExceptionMessage);
            }

            teacher.Status = "Disapproved";
            await repo.SaveChangesAsync();
        }

        //This method "delete" teacher. It actually changes the IsActive property to false
        public async Task DeleteTeacher(string userId)
        {
            var teacher = await repo.All<Teacher>()
                .Where(t => t.UserId == userId)
                .FirstOrDefaultAsync();

            if(teacher == null)
            {
                throw new NullReferenceException(GlobalExceptions.TeacherDoesNotExistExceptionMessage);
            }

            teacher.IsActive = false;

            await repo.SaveChangesAsync();
        }

        //This method returns a collection of UserModel. It is used for displaying all teachers in the admin panel when filtrated
        public async Task<List<UserModel>> GetAllTeachers()
        {
            var model = await repo.AllReadonly<Teacher>()
                .Where(t => t.IsActive == true)
                .OrderByDescending(p => p.Id)
                .Select(t => new UserModel
                {
                    UserInRoleId = t.Id,
                    Id = t.UserId,
                    Name = t.User.FirstName + " " + t.User.LastName,
                    Role = "Teacher",
                    City = t.User.City,
                    SchoolName = t.School.Name,
                    ProfilePictureUrl = t.User.ProfilePictureUrl,
                })
                .ToListAsync(); 

            return model;
        }

        //This method returns list of teacherModel of all teachers with status waiting.
        //It is used for displaying them in the admin panel. There they wait to be approved by the admin
        public async Task<List<TeacherModel>> GetAllTeachersWithStatusWaiting()
        {
            var model = await repo.AllReadonly<Teacher>()
                 .Where(t => t.Status == "Waiting" && t.User.IsActive)
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
                     Subject = t.Subject,
                     AboutMe = t.User.AboutMe,
                     CreatedOn = t.User.CreatedOn.ToString("yyyy-M-d")
                 })
                 .ToListAsync();

            return model;
        }

        //This method returns the id of theacher by the id of its user. 
        public async Task<int> GetTeacherIdByUserId(string id)
        {
            var teacher = await repo.All<Teacher>()
                .Where(t => t.UserId == id)
                .FirstOrDefaultAsync();

            if (teacher == null)
            {
                throw new NullReferenceException(GlobalExceptions.TeacherDoesNotExistExceptionMessage);
            }

            return teacher.Id;
        }
    }
}
