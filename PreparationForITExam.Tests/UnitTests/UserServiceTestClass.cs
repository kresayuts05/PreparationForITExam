using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Exception;
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
    public class UserServiceTestClass : UnitTestsBase
    {
        private IRepository repo;
        private UserManager<User> userManager;
        private IStudentService studentService;
        private ITeacherService teacherService;
        private IMonUserService monUserService;
        private IUserService userService;

        [SetUp]
        public async Task Setup()
        {
            this.repo = new Repository(this.context);
            this.studentService = new StudentService(repo);
            this.teacherService = new TeacherService(repo);
            this.monUserService = new MonUserService(repo);
            this.userService = new UserService(repo, userManager, studentService, teacherService, monUserService);
        }

        [Test]
        [TestCase("")]
        [TestCase("sth")]
        [TestCase("client2@gmail.com")]
        [TestCase("constructor@gmail.co")]
        public async Task UserExistsByEmaiilShouldReturnFalse(string email)
        {
            var dbUser = await userService.UserByEmailExists(email);
            Assert.That(dbUser, Is.EqualTo(false));
        }

        [Test]
        [TestCase("admin@gmail.com")]
        public async Task UserExistsByEmailShouldReturnTrue(string email)
        {
            var dbUser = await userService.UserByEmailExists(email);

            Assert.That(dbUser, Is.EqualTo(true));
        }

        [Test]
        [TestCase("AdminTestId")]
        public async Task UserNameByIdShouldReturnStringName(string id)
        {
            var dbUser = await userService.UserNameById(id);

            Assert.That(dbUser, Is.EqualTo("Креса Цветкова"));
        }

        [Test]
        [TestCase("MonUserTestId")]
        [TestCase("TeacherTestId")]
        [TestCase("StudentTestId")]
        public async Task GetUserInfoByIdShouldReturnCorrectResult(string id)
        {
            var user = await userService.GetUserInfo(id);

            var dbUser = await repo.GetByIdAsync<User>(id);

            Assert.IsNotNull(user);
            Assert.That(user.Email, Is.EqualTo(dbUser.Email));
            Assert.That(user.Phone, Is.EqualTo(dbUser.PhoneNumber));
            Assert.That(user.AboutMe, Is.EqualTo(dbUser.AboutMe));
            Assert.That(user.City, Is.EqualTo(dbUser.City));
            Assert.That(user.RoleName, Is.EqualTo(dbUser.RoleName));
            Assert.That(user.ProfilePicture, Is.EqualTo(dbUser.ProfilePictureUrl));

        }

        [Test]
        public async Task AllUsersShouldReturnCorrectCollection()
        {
            var dbUsers = await repo.All<User>()
                .Where(u => u.IsActive == true)
                .OrderByDescending(x => x.Id)
                .Take(9)
                .ToListAsync();

            var allUser = (List<UserModel>)await userService.GetAllUsers(0);

            Assert.AreEqual(dbUsers.Count, allUser.Count);
            Assert.AreEqual(dbUsers[1].Id, allUser[1].Id);
        }

        [Test]
        [TestCase("StudentTestId")]
        [TestCase("TeacherTestId")]
        [TestCase("MonUserTestId")]
        public async Task DeleteUserShouldChangeStatusSuccessfully(string id)
        {
            await userService.DeleteUser(id);
            var dbUser = await repo.GetByIdAsync<User>(id);

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
            var ex = Assert.ThrowsAsync<NullReferenceException>(async () => await userService.DeleteUser(id));
            Assert.AreEqual(GlobalExceptions.UserDoesNotExistExceptionMessage, ex.Message);
        }
    }
}

