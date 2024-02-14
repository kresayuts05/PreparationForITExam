using PreparationForITExam.Core.Models.Exercise;
using PreparationForITExam.Core.Models.Lesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.SectionOfCurricular
{
    public class SectionLessonViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Module { get; set; }

        public List<LessonModel> Lessons { get; set; }
        public List<ExerciseModel> Exercises { get; set; }
    }
}
