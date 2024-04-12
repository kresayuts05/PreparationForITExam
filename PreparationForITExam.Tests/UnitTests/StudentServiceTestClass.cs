using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Exception;
using PreparationForITExam.Core.Models.Account;
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
    public class StudentServiceTestClass : UnitTestsBase
    {
        private IRepository repo;
        private IStudentService studentService;

        [SetUp]
        public async Task Setup()
        {
            this.repo = new Repository(this.context);
            this.studentService = new StudentService(repo);
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

            await studentService.Create("StudentTestId1", 1);

            var dbStudent = await repo.GetByIdAsync<Student>(2);

            Assert.IsNotNull(dbStudent);
            Assert.That(dbStudent.UserId, Is.EqualTo("StudentTestId1"));
            Assert.That(dbStudent.User.Email, Is.EqualTo("student2@gmail.com"));
        }

        [Test]
        [TestCase("StudentTestId")]
        public async Task GetStudentIdByUserIdShouldReturnCorrectResult(string id)
        {
            var studentId = await studentService.GetStudentIdByUserId(id);

            var dbStudent = await repo.GetByIdAsync<Student>(studentId);
            var dbUser = await repo.GetByIdAsync<User>(id);

            Assert.IsNotNull(dbStudent);
            Assert.That(dbStudent.Id, Is.EqualTo(studentId));
            Assert.That(dbStudent.User.Email, Is.EqualTo(dbUser.Email));
        }

        [Test]
        [TestCase("")]
        [TestCase("sth")]
        [TestCase("1")]
        [TestCase("ClientTestId2")]
        [TestCase("ConstructorTestIdDisactivaated")]
        [TestCase(null)]
        public async Task GetStudentIdByUserIdShouldThrowExceptionWhenIdWrong(string id)
        {
            var ex = Assert.ThrowsAsync<NullReferenceException>(async () => await studentService.GetStudentIdByUserId(id));
            Assert.AreEqual(GlobalExceptions.StudentDoesNotExistExceptionMessage, ex.Message);
        }


        [Test]
        public async Task AllStudentsShouldReturnCorrectCollection()
        {
            var dbTeachers = await repo.AllReadonly<Student>()
                 .Where(t => t.IsActive == true)
                 .OrderByDescending(p => p.Id)
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

            List<UserModel> teachers = (List<UserModel>)await studentService.GetAllStudents();

            for (int i = 0; i < teachers.Count; i++)
            {
                Assert.AreEqual(dbTeachers[i].Id, teachers[i].Id);
            }
        }


        [Test]
        [TestCase("StudentTestId")]
        public async Task DeleteUserShouldChangeStatusSuccessfully(string id)
        {
            await studentService.DeleteStudent(id);
            int teacherId = await studentService.GetStudentIdByUserId(id);
            var dbUser = await repo.GetByIdAsync<Student>(teacherId);

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
            var ex = Assert.ThrowsAsync<NullReferenceException>(async () => await studentService.DeleteStudent(id));
            Assert.AreEqual(GlobalExceptions.StudentDoesNotExistExceptionMessage, ex.Message);
        }
    }
}
