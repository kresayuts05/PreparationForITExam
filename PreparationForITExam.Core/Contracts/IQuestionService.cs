using PreparationForITExam.Core.Models.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface IQuestionService
    {
        Task<List<QuestionViewModel>> GetAllLessonQuestionsByLessonId(int lessonId);

        Task CreateQuestion(QuestionFormViewModel model);
    }
}
