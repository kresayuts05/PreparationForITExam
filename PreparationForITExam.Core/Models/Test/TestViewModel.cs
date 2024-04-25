using PreparationForITExam.Core.Models.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.Test
{
    public class TestViewModel
    {
        public List<TestScoreViewModel> TestScores { get; set; } = new List<TestScoreViewModel>();
        public List<QuestionViewModel> Questions { get; set; } = new List<QuestionViewModel>();

        public int Score { get; set; }
    }
}
