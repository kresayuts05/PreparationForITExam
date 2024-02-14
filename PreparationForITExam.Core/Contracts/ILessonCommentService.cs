using PreparationForITExam.Core.Models.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface ILessonCommentService
    {
        Task<List<LessonCommentViewModel>> GetAllLessonCommentsByLessonId(int lessonId);

        Task CreateLessonComment(LessonCommentFormViewModel model);
    }
}
