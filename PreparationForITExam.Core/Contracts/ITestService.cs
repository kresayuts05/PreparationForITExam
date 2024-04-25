using PreparationForITExam.Core.Models.Test;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface ITestService
    {
        Task<List<TestScoreViewModel>> GetAllTestScores();

        Task<TestViewModel> GenerateTest();
    }
}
