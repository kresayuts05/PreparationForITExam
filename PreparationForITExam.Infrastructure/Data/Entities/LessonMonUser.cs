using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class LessonMonUser
    {
        [ForeignKey(nameof(Lesson))]
        public int LessonId { get; set; }

        public Lesson Lesson { get; set; }

        [ForeignKey(nameof(MonUser))]
        public int MonUserId { get; set; }

        public MonUser MonUser { get; set; }
    }
}
