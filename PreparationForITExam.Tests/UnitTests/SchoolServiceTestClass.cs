using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.School;
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
    public class SchoolServiceTestClass : UnitTestsBase
    {
        private IRepository repo;
        private ISchoolService schoolService;

        [SetUp]
        public async Task Setup()
        {
            this.repo = new Repository(this.context);
            this.schoolService = new SchoolService(repo);
        }

        [Test]
        public async Task AllSchoolsShouldReturnCorrectCollection()
        {
            var dbschools = await repo.All<School>()
                .Select(s => new SchoolModel
                {
                    Id = s.Id,
                    Name = s.Name,
                    City = s.City,
                })
                .ToListAsync();

            List<SchoolModel> teachers = (List<SchoolModel>)await schoolService.AllSchools();

            for (int i = 0; i < teachers.Count; i++)
            {
                Assert.AreEqual(dbschools[i].Id, teachers[i].Id);
            }
        }

    }
}
