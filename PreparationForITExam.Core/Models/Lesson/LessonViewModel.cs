using PreparationForITExam.Core.Models.Material;
using PreparationForITExam.Core.Models.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.Lesson
{
    public class LessonViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Module { get; set; }

        public string SectionOfCurricular { get; set; }

        public string? Content { get; set; }

        public string PresentationUrl { get; set; }

        public List<MaterialModel> Materials { get; set; }

        public List<LessonCommentViewModel> Questions { get; set; }
    }
}
