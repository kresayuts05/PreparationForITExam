using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Exception;
using PreparationForITExam.Core.Models.Account;
using PreparationForITExam.Core.Models.Post;
using PreparationForITExam.Core.Models.Teacher;
using PreparationForITExam.Core.Models.User;
using PreparationForITExam.Core.Services;
using PreparationForITExam.Infrastructure.Data.Common;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Tests.UnitTests
{
    [TestFixture]
    public class TeacherServiceTestClass : UnitTestsBase
    {
        private IRepository repo;
        private ITeacherService teacherService;

        [SetUp]
        public async Task Setup()
        {
            this.repo = new Repository(this.context);
            this.teacherService = new TeacherService(repo);
        }

        [Test]
        public async Task CreateTeacherShouldReturnCorectResult()
        {
            var user = new User()
            {
                Id = "StudentTestId1",
                Email = "student2@gmail.com",
                NormalizedEmail = "STUDENT@GMAIL.COM",
                UserName = "student@gmail.com",
                NormalizedUserName = "STUDENT@GMAIL.COM",
                FirstName = "Никол",
                LastName = "Груева",
                City = "Миделбург",
                PhoneNumber = "0886121262",
                RoleName = "Student",
                AboutMe = "Занимавам се с програмиране от 3 години. Интересувам се от кибер сигурност, а именно и това искам да уча след като завърша.",
                ProfilePictureUrl = "https://res.cloudinary.com/dmv8nabul/image/upload/v1707334404/nikol_prlrcl.jpg"
            };

            await repo.AddAsync(user);
            await repo.SaveChangesAsync();

            RegisterViewModel model = new RegisterViewModel
            {
                Experience = 12,
                Subject = "sth"
            };

            await teacherService.Create("StudentTestId1", model, 1);

            var dbTeacher = await repo.GetByIdAsync<Teacher>(3);

            Assert.IsNotNull(dbTeacher);
            Assert.That(dbTeacher.UserId, Is.EqualTo("StudentTestId1"));
            Assert.That(dbTeacher.User.Email, Is.EqualTo("student2@gmail.com"));
            Assert.That(dbTeacher.Experience, Is.EqualTo(12));
            Assert.That(dbTeacher.Subject, Is.EqualTo("sth"));
        }

        [Test]
        [TestCase("TeacherTestId")]
        public async Task GetTeacherIdByUserIdShouldReturnCorrectResult(string id)
        {
            var teacherId = await teacherService.GetTeacherIdByUserId(id);

            var dbTeacher = await repo.GetByIdAsync<Teacher>(teacherId);
            var dbUser = await repo.GetByIdAsync<User>(id);

            Assert.IsNotNull(dbTeacher);
            Assert.That(dbTeacher.Id, Is.EqualTo(teacherId));
            Assert.That(dbTeacher.User.Email, Is.EqualTo(dbUser.Email));
        }


        [Test]
        [TestCase("")]
        [TestCase("sth")]
        [TestCase("1")]
        [TestCase("ClientTestId2")]
        [TestCase("ConstructorTestIdDisactivaated")]
        [TestCase(null)]
        public async Task GetTeacherIdByUserIdShouldThrowExceptionWhenIdWrong(string id)
        {
            var ex = Assert.ThrowsAsync<NullReferenceException>(async () => await teacherService.GetTeacherIdByUserId(id));
            Assert.AreEqual(GlobalExceptions.TeacherDoesNotExistExceptionMessage, ex.Message);
        }

        [Test]
        public async Task AllTeachersShouldReturnCorrectCollection()
        {
            var dbTeachers = await repo.All<Teacher>()
                .Where(t=>t.IsActive == true)
                .OrderByDescending(t => t.Id)
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

            List<UserModel> teachers = (List<UserModel>)await teacherService.GetAllTeachers();

            for (int i = 0; i < teachers.Count; i++)
            {
                Assert.AreEqual(dbTeachers[i].Id, teachers[i].Id);
            }
        }


        [Test]
        public async Task AllTeachersWithStatusWaitingShouldReturnCorrectCollection()
        {
            var dbTeachers = await repo.AllReadonly<Teacher>()
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

            List<TeacherModel> teachers = (List<TeacherModel>)await teacherService.GetAllTeachersWithStatusWaiting();

            for (int i = 0; i < teachers.Count; i++)
            {
                Assert.AreEqual(dbTeachers[i].UserId, teachers[i].UserId);
            }
        }

        [Test]
        [TestCase("TeacherNotApprovedId")]
        public async Task TeacherStatusShouldBeChangedToApproved(string id)
        {

            await teacherService.ApproveTeacher(id);
            var dbTeacher = await repo.AllReadonly<Teacher>()
                .Where(t => t.UserId == id)
                .FirstOrDefaultAsync();

            Assert.IsNotNull(dbTeacher);
            Assert.That(dbTeacher.Status, Is.EqualTo("Approved"));
        }

        [Test]
        [TestCase("")]
        [TestCase("sth")]
        [TestCase("1")]
        [TestCase("ClientTestId2")]
        [TestCase("ConstructorTestIdDisactivaated")]
        [TestCase(null)]
        public async Task TeacherStatusShouldThrowExceptionWhenIdWrong(string id)
        {
            var ex = Assert.ThrowsAsync<NullReferenceException>(async () => await teacherService.ApproveTeacher(id));
            Assert.AreEqual(GlobalExceptions.TeacherDoesNotExistExceptionMessage, ex.Message);
        }


        [Test]
        [TestCase("TeacherTestId")]
        public async Task DeleteUserShouldChangeStatusSuccessfully(string id)
        {
            await teacherService.DeleteTeacher(id);
            int teacherId = await teacherService.GetTeacherIdByUserId(id);
            var dbUser = await repo.GetByIdAsync<Teacher>(teacherId);

            Assert.AreEqual(dbUser.IsActive, false);
        }

        [Test]
        [TestCase("")]
        [TestCase("sth")]
        [TestCase("ClientTestId2")]
        [TestCase("ConstructorTestIdDisactivaated")]
        [TestCase(null)]
        public async Task DeactivateUserShouldThrowNullReferenceException(string id)
        {
            var ex = Assert.ThrowsAsync<NullReferenceException>(async () => await teacherService.DeleteTeacher(id));
            Assert.AreEqual(GlobalExceptions.TeacherDoesNotExistExceptionMessage, ex.Message);
        }


        [Test]
        [TestCase("TeacherNotApprovedId")]
        public async Task TeacherStatusShouldBeChangedToDeclined(string id)
        {
            int teacherId = await teacherService.GetTeacherIdByUserId(id);

            await teacherService.DeclineTeacherRole(teacherId);
            var dbTeacher = await repo.AllReadonly<Teacher>()
                .Where(t => t.UserId == id)
                .FirstOrDefaultAsync();

            Assert.IsNotNull(dbTeacher);
            Assert.That(dbTeacher.Status, Is.EqualTo("Disapproved"));
        }

        [Test]
        [TestCase(5)]
        [TestCase(0)]
        [TestCase(-1)]
        public async Task TeacherStatusDeclinedShouldThrowExceptionWhenIdWrong(int id)
        {
            var ex = Assert.ThrowsAsync<NullReferenceException>(async () => await teacherService.DeclineTeacherRole(id));
            Assert.AreEqual(GlobalExceptions.TeacherDoesNotExistExceptionMessage, ex.Message);
        }
    }
}
