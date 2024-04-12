using Microsoft.AspNetCore.Identity;
using PreparationForITExam.Infrastructure.Data.Entities;
using PreparationForITExam.Infrastructure.Data;
using PreparationForITExam.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Tests.UnitTests
{
    public class UnitTestsBase
    {
        protected List<IdentityRole> roles;
        protected List<User> users;
        protected List<Student> students;
        protected List<Teacher> teachers;
        protected List<SectionOfCurricular> sectionOfCurriculars;
        protected List<School> schools;
        protected List<Review> reviews;
        protected List<RequestLesson> requestLessons;
        protected List<RequestExercise> requestExercises;
        protected List<Post> posts;
        protected List<News> news;
        protected List<MonUser> monUsers;
        protected List<ModuleOfCurricular> moduleOfCurriculars;
        protected List<LessonMonUser> lessonMonUsers;
        protected List<LessonMaterial> lessonMaterials;
        protected List<Lesson> lessons;
        protected List<ImageComment> imageComments;
        protected List<Image> images;
        protected List<ExerciseMaterial> exerciseMaterials;
        protected List<Exercise> exercises;
        protected List<Comment> comments;
        protected List<Answer> answers;
        protected List<IdentityUserRole<string>> userRoles;

        protected PreparationForITExamDbContext context;

        [SetUp]
        public async Task SetUpBase()
        {
            this.context = DatabaseMock.Instance;
            await this.SeedData();
        }

        public async Task SeedData()
        {
            users = new List<User>()
         {
             new User()
             {
             Id = "AdminTestId",
             Email = "admin@gmail.com",
             NormalizedEmail = "ADMIN@GMAIL.COM",
             UserName = "admin@gmail.com",
             NormalizedUserName = "ADMIN@GMAIL.COM",
             FirstName = "Креса",
             LastName = "Цветкова",
             City = "Казанлък",
             PhoneNumber = "0886121260",
             RoleName = "Administrator",
             AboutMe = "Разработвам това приложение, за да участвам в олимпиада по информационни технологии. Темата си избрах след първата матура по Информатика. Моите учители и приятели, които се явиха на това ДЗИ, имаха проблем с намирането на полезни материали и информация за самата матура. Това приложение се надявам, че би олеснило подготовката, защото хора с еднакви интереси и задачи могат да комуникират и обменят знания. Също така, учители могат да предадат знанията си на ученици, които наистина имат желание да се научат и полагат усилия.",
             ProfilePictureUrl = "https://res.cloudinary.com/dmv8nabul/image/upload/v1707334401/kresa_bkbaoa.jpg"
             },

             new User()
         {
             Id = "MonUserTestId",
             Email = "monuser@gmail.com",
             NormalizedEmail = "MONUSER@GMAIL.COM",
             UserName = "monuser@gmail.com",
             NormalizedUserName = "MONUSER@GMAIL.COM",
             FirstName = "Валентин",
             LastName = "Терзиев",
             City = "Кърджали",
             PhoneNumber = "0886121261",
             RoleName = "MonUser",
             AboutMe = "Работя в МОН от 5 години. Преподавам по Информатика в частна школа. Програмирането е моята страст. Обичам фо повече от приятелката ми.",
             ProfilePictureUrl = "https://res.cloudinary.com/dmv8nabul/image/upload/v1707334408/valentin_u5en92.jpg"
          },
             new User()
         {
             Id = "StudentTestId",
             Email = "student@gmail.com",
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
         },
             new User()
         {
             Id = "TeacherTestId",
             Email = "teacher@gmail.com",
             NormalizedEmail = "TEACHER@GMAIL.COM",
             UserName = "teacher@gmail.com",
             NormalizedUserName = "TEACHER@GMAIL.COM",
             FirstName = "Ивета",
             LastName = "Найденова",
             City = "София",
             PhoneNumber = "0886121262",
             RoleName = "Teacher",
             AboutMe = "Учителка съм от 12 години. Избрах тази професия, защото работата с деца е моята страст. В работата си опитвам да предам знанията си колкото повече мога. Мой интерес е работата с ASP.NET.",
             ProfilePictureUrl = "https://res.cloudinary.com/dmv8nabul/image/upload/v1707334395/iveta_rknyn3.jpg"
         },
                  new User()
         {
             Id = "TeacherNotApprovedId",
             Email = "teacher@gmail.com",
             NormalizedEmail = "TEACHER@GMAIL.COM",
             UserName = "teacher@gmail.com",
             NormalizedUserName = "TEACHER@GMAIL.COM",
             FirstName = "Ивета",
             LastName = "Найденова",
             City = "София",
             PhoneNumber = "0886121262",
             RoleName = "Teacher",
             AboutMe = "Учителка съм от 12 години. Избрах тази професия, защото работата с деца е моята страст. В работата си опитвам да предам знанията си колкото повече мога. Мой интерес е работата с ASP.NET.",
             ProfilePictureUrl = "https://res.cloudinary.com/dmv8nabul/image/upload/v1707334395/iveta_rknyn3.jpg"
         }
     };

            students = new List<Student>()
            {
                new Student
            {
                Id= 1,
                SchoolId = 152,
                UserId = "StudentTestId"
            },

            };

            teachers = new List<Teacher>()
            {
                new Teacher
            {
               Id = 1,
               SchoolId = 289,
               Experience = 12,
               Subject = "Информатика",
               UserId = "TeacherTestId",
               Status = "Approved"
            },
                new Teacher
            {
               Id = 2,
               SchoolId = 289,
               Experience = 12,
               Subject = "Информатика",
               UserId = "TeacherNotApprovedId",
               Status = "Waiting"
            },

            };

            monUsers = new List<MonUser>
            {
                new MonUser
            {
                Id = 1,
                UserId = "MonUserTestId"
            }
            };

            posts = new List<Post>
            {
                new Post
            {
                Id = 1,
                Title= "Git игра",
                ShortDescription= "Попаднах на страхотна игра, която ти помага да научиш Git",
                Description= "Имах затруднения да разбера Git технологията, но с помощта на тази игра бързо осъвършенствах функциите и начина на използване.",
                PostedOn = DateTime.Now,
                UsefulUrl = "https://learngitbranching.js.org/?locale=en_US",
                UserId = "StudentTestId",
            },
                 new Post
            {
                Id = 2,
                Title= "Git игра",
                ShortDescription= "Попаднах на страхотна игра, която ти помага да научиш Git",
                Description= "Имах затруднения да разбера Git технологията, но с помощта на тази игра бързо осъвършенствах функциите и начина на използване.",
                PostedOn = DateTime.Now,
                UsefulUrl = "https://learngitbranching.js.org/?locale=en_US",
                UserId = "StudentTestId",
            }
        };


            await context.Users.AddRangeAsync(users);
            await context.Students.AddRangeAsync(students);
            await context.Teachers.AddRangeAsync(teachers);
            await context.MonUsers.AddRangeAsync(monUsers);
            await context.Posts.AddRangeAsync(posts);

            await context.SaveChangesAsync();
        }

        public async Task TearDownBase()
        {
            await this.context.DisposeAsync();
        }
    }
}
