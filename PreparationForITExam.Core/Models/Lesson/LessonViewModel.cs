using PreparationForITExam.Core.Models.Material;
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

        public List<MaterialViewModel> Presentation { get; set; }

        public List<MaterialViewModel> Materials { get; set; }
    }
}
