using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Test;
using PreparationForITExam.Infrastructure.Data.Common;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Services
{
    public class TestScoreService : ITestScoreService
    {
        private readonly IRepository repo;

        public TestScoreService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task Create(int score, string userId)
        {
            var testScore = new TestScore()
            {
                Score = score,
                UserId = userId,
            };

            await repo.AddAsync(testScore);
            await repo.SaveChangesAsync();
        }
    }
}
