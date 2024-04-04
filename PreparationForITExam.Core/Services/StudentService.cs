using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
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
    public class StudentService : IStudentService
    {
        private readonly IRepository repo;

        public StudentService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task Create(string userId, int schoolId)
        {
            var student = new Student()
            {
                UserId = userId,
                SchoolId = schoolId
            };

            await repo.AddAsync(student);
            await repo.SaveChangesAsync();
        }

        public async Task DeleteStudent(string userId)
        {
            var student = await repo.All<Student>()
                .Where(t => t.UserId == userId)
                .FirstOrDefaultAsync();

            student.IsActive = false;

            await repo.SaveChangesAsync();
        }

        public async Task<List<UserModel>> GetAllStudents(int page)
        {
            var model = await repo.AllReadonly<Student>()
                 .Where(t => t.IsActive == true)
                 .OrderByDescending(p => p.Id)
                 .Skip(9 * ((int)(page == 0 ? 1 : page) - 1))
                 .Take(9)
                 .Select(t => new UserModel
                 {
                     UserInRoleId = t.Id,
                     Id = t.UserId,
                     Name = t.User.FirstName + " " + t.User.LastName,
                     Role = "Student",
                     City = t.User.City,
                     SchoolName = t.School.Name,
                     ProfilePictureUrl = t.User.ProfilePictureUrl
                 })
                 .ToListAsync();

            return model;
        }

        public async Task<int> GetStudentIdByUserId(string userId)
        {
            var student = await repo.AllReadonly<Student>()
                 .Where(s => s.UserId == userId)
                 .FirstOrDefaultAsync();

            return student.Id;
        }
    }
}
