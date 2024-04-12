using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Exception;
using PreparationForITExam.Core.Models.Post;
using PreparationForITExam.Core.Models.User;
using PreparationForITExam.Core.Services;
using PreparationForITExam.Infrastructure.Data.Common;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Tests.UnitTests
{

    [TestFixture]
    public class PostServiceTestClass : UnitTestsBase
    {
        private IRepository repo;
        private IPostService postService;

        [SetUp]
        public async Task Setup()
        {
            this.repo = new Repository(this.context);
            this.postService = new PostService(repo, null, null);
        }

        [Test]
        public async Task CreateQuestionShouldReturnCorectResult()
        {
            var post = new Post
            {
                Title = "Test",
                Description = "Test",
                ShortDescription = "Test",
                UsefulUrl = null,
                UserId = "StudentTestId",
                IsItQuestion = true
            };

            await repo.AddAsync(post);
            await repo.SaveChangesAsync();

            var model = new PostFormViewModel
            {
                Title = "Test",
                Description = "Test",
                ShortDescription = "Test",
                UsefulUrl = null,
                UserId = "StudentTestId",
                IsItQuestion = true
            };

            await postService.Create(model, true);

            var dbStudent = await repo.GetByIdAsync<Post>(3);

            Assert.IsNotNull(dbStudent);
            Assert.That(dbStudent.UserId, Is.EqualTo("StudentTestId"));
            Assert.That(dbStudent.User.Email, Is.EqualTo("student@gmail.com"));
            Assert.That(dbStudent.Title, Is.EqualTo("Test"));
            Assert.That(dbStudent.Description, Is.EqualTo("Test"));
            Assert.That(dbStudent.ShortDescription, Is.EqualTo("Test"));
            Assert.That(dbStudent.IsItQuestion, Is.EqualTo(true));
        }

        [Test]
        public async Task CreatePostShouldReturnCorectResult()
        {
            var post = new Post
            {
                Title = "Test",
                Description = "Test",
                ShortDescription = "Test",
                UsefulUrl = null,
                UserId = "StudentTestId",
                IsItQuestion = false
            };

            await repo.AddAsync(post);
            await repo.SaveChangesAsync();

            var model = new PostFormViewModel
            {
                Title = "Test",
                Description = "Test",
                ShortDescription = "Test",
                UsefulUrl = null,
                UserId = "StudentTestId",
                IsItQuestion = false
            };

            await postService.Create(model, false);

            var dbStudent = await repo.GetByIdAsync<Post>(3);

            Assert.IsNotNull(dbStudent);
            Assert.That(dbStudent.UserId, Is.EqualTo("StudentTestId"));
            Assert.That(dbStudent.User.Email, Is.EqualTo("student@gmail.com"));
            Assert.That(dbStudent.Title, Is.EqualTo("Test"));
            Assert.That(dbStudent.Description, Is.EqualTo("Test"));
            Assert.That(dbStudent.ShortDescription, Is.EqualTo("Test"));
            Assert.That(dbStudent.IsItQuestion, Is.EqualTo(false));
        }

        [Test]
        public async Task AllPostsShouldReturnCorrectCollection()
        {
            var dbTeachers = await repo.AllReadonly<Post>()
                 .Where(p => p.IsActive)
                 .OrderByDescending(p => p.Id)
                 .Take(9)
                 .Select(p => new PostViewModel
                 {
                     Id = p.Id,
                     Title = p.Title,
                     Description = p.Description,
                     ShortDescription = p.ShortDescription,
                     UserId = p.UserId,
                     UserName = p.User.FirstName + " " + p.User.LastName,
                     UserProfilePicture = p.User.ProfilePictureUrl,
                     UsefulUrl = p.UsefulUrl,
                     PostedOn = p.PostedOn.ToString("yyyy-M-d"),

                 })
                 .ToListAsync();

            List<PostViewModel> teachers = (List<PostViewModel>)await postService.GetAllPosts(0);

            for (int i = 0; i < teachers.Count; i++)
            {
                Assert.AreEqual(dbTeachers[i].Id, teachers[i].Id);
            }
        }


        [Test]
        public async Task AllOnlyPostsShouldReturnCorrectCollection()
        {
            var dbTeachers = await repo.AllReadonly<Post>()
                 .Where(p => p.IsActive && p.IsItQuestion == false)
                 .OrderByDescending(p => p.Id)
                 .Take(9)
                 .Select(p => new PostViewModel
                 {
                     Id = p.Id,
                     Title = p.Title,
                     Description = p.Description,
                     ShortDescription = p.ShortDescription,
                     UserId = p.UserId,
                     UserName = p.User.FirstName + " " + p.User.LastName,
                     UserProfilePicture = p.User.ProfilePictureUrl,
                     UsefulUrl = p.UsefulUrl,
                     PostedOn = p.PostedOn.ToString("yyyy-M-d"),
                     CommentsCount = p.Comments.Where(c => c.IsActive).ToList().Count

                 })
                 .ToListAsync();

            List<PostViewModel> teachers = (List<PostViewModel>)await postService.GetOnlyPosts(0);

            for (int i = 0; i < teachers.Count; i++)
            {
                Assert.AreEqual(dbTeachers[i].Id, teachers[i].Id);
            }
        }


        [Test]
        public async Task AllOnlyQuestionsShouldReturnCorrectCollection()
        {
            var dbTeachers = await repo.AllReadonly<Post>()
                 .Where(p => p.IsActive && p.IsItQuestion == true)
                 .OrderByDescending(p => p.Id)
                 .Take(9)
                 .Select(p => new PostViewModel
                 {
                     Id = p.Id,
                     Title = p.Title,
                     Description = p.Description,
                     ShortDescription = p.ShortDescription,
                     UserId = p.UserId,
                     UserName = p.User.FirstName + " " + p.User.LastName,
                     UserProfilePicture = p.User.ProfilePictureUrl,
                     UsefulUrl = p.UsefulUrl,
                     PostedOn = p.PostedOn.ToString("yyyy-M-d"),
                     CommentsCount = p.Comments.Where(c => c.IsActive).ToList().Count

                 })
                 .ToListAsync();

            List<PostViewModel> teachers = (List<PostViewModel>)await postService.GetOnlyQuestions(0);

            for (int i = 0; i < teachers.Count; i++)
            {
                Assert.AreEqual(dbTeachers[i].Id, teachers[i].Id);
            }
        }

        [Test]
        public async Task GetPostsCountShouldReturnCorrectCollection()
        {
            var dbTeachers = await repo.AllReadonly<Post>()
                .Where(p => p.IsActive)
                .ToListAsync();

            int teachers = await postService.GetPostCount();

            Assert.AreEqual(dbTeachers.Count, teachers);
        }

        [Test]
        public async Task GetOnlyPostsCountShouldReturnCorrectCollection()
        {
            var dbTeachers = await repo.AllReadonly<Post>()
                .Where(p => p.IsActive && p.IsItQuestion == false)
                .ToListAsync();

            int teachers = await postService.GetOnlyPostsCount();

            Assert.AreEqual(dbTeachers.Count, teachers);
        }
        [Test]
        public async Task GetOnlyQuestionsCountShouldReturnCorrectCollection()
        {
            var dbTeachers = await repo.AllReadonly<Post>()
                .Where(p => p.IsActive && p.IsItQuestion == true)
                .ToListAsync();

            int teachers = await postService.GetOnlyQuestionsCount();

            Assert.AreEqual(dbTeachers.Count, teachers);
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        public async Task GetPostInfoByIdShouldReturnCorrectResult(int id)
        {
            var user = await postService.GetPostInfo(id);

            var dbUser = await repo.GetByIdAsync<Post>(id);

            Assert.IsNotNull(user);
            Assert.That(user.Description, Is.EqualTo(dbUser.Description));
            Assert.That(user.ShortDescription, Is.EqualTo(dbUser.ShortDescription));
            Assert.That(user.Title, Is.EqualTo(dbUser.Title));
            Assert.That(user.IsItQuestion, Is.EqualTo(dbUser.IsItQuestion));

        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        public async Task EditPostShouldReturnCorectResult(int id)
        {
            var model = new PostFormViewModel
            {
                Id = id,
                Title = "Test",
                Description = "Test",
                ShortDescription = "Test",
                UsefulUrl = null,
                UserId = "StudentTestId",
                IsItQuestion = true
            };

            await postService.Edit(model);

            var dbStudent = await repo.GetByIdAsync<Post>(id);

            Assert.IsNotNull(dbStudent);
            Assert.That(dbStudent.UserId, Is.EqualTo("StudentTestId"));
            Assert.That(dbStudent.User.Email, Is.EqualTo("student@gmail.com"));
            Assert.That(dbStudent.Title, Is.EqualTo("Test"));
            Assert.That(dbStudent.Description, Is.EqualTo("Test"));
            Assert.That(dbStudent.ShortDescription, Is.EqualTo("Test"));
            Assert.That(dbStudent.IsItQuestion, Is.EqualTo(true));
        }


        [Test]
        [TestCase("StudentTestId")]
        [TestCase("TeacherTestId")]
        public async Task AllPostsUrlsShouldReturnCorrectCollection(string id)
        {
            var dbTeachers = await repo.AllReadonly<Post>()
                .Where(p => p.UserId == id)
                .Where(p => p.IsActive == true && p.IsItQuestion == false)
                .Select(p => new PostModel
                {
                    Id = p.Id,
                    Title = p.Title,
                })
                .ToListAsync();

            List<PostModel> teachers = (List<PostModel>)await postService.GetAllPostsUrlsByUserId(id);

            for (int i = 0; i < teachers.Count; i++)
            {
                Assert.AreEqual(dbTeachers[i].Id, teachers[i].Id);
            }
        }


        [Test]
        [TestCase("StudentTestId")]
        [TestCase("TeacherTestId")]
        public async Task AllQuestionsUrlsShouldReturnCorrectCollection(string id)
        {
            var dbTeachers = await repo.AllReadonly<Post>()
                .Where(p => p.UserId == id)
                .Where(p => p.IsActive == true && p.IsItQuestion == true)
                .Select(p => new PostModel
                {
                    Id = p.Id,
                    Title = p.Title,
                })
                .ToListAsync();

            List<PostModel> teachers = (List<PostModel>)await postService.GetAllQuestionsUrlsByUserId(id);

            for (int i = 0; i < teachers.Count; i++)
            {
                Assert.AreEqual(dbTeachers[i].Id, teachers[i].Id);
            }
        }

        [Test]
        [TestCase(2)]
        [TestCase(1)]
        public async Task DeleteUserShouldChangeStatusSuccessfully(int id)
        {
            await postService.Delete(id);
            var dbUser = await repo.GetByIdAsync<Post>(id);

            Assert.AreEqual(dbUser.IsActive, false);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(81)]
        public async Task DeactivatePostShouldThrowNullReferenceException(int id)
        {
            var ex = Assert.ThrowsAsync<NullReferenceException>(async () => await postService.Delete(id));
            Assert.AreEqual(GlobalExceptions.PostDoesNotExistExceptionMessage, ex.Message);
        }
    }
}
