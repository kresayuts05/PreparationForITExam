using PreparationForITExam.Core.Models.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface ITestScoreService
    {
        Task Create(int score, string userId);
    }
}
