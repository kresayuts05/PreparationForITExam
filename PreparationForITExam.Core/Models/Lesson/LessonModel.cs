using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.Lesson
{
    public class LessonModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public int SectionOfCurricularId { get; set; }

        public string Content { get; set; }

        public bool IsActive { get; set; }
    }
}
