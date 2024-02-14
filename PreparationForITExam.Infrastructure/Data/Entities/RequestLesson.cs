using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.RequestConstraints;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class RequestLesson
    {
        public RequestLesson()
        {
            this.IsActive= true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(Teacher))]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        [Required]
        [ForeignKey(nameof(Lesson))]
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }

        [Required]
        [MaxLength(ChangedContentMaxLength)]
        public string ChangedContent { get; set; }

        [Required]
        [MaxLength(SuggestionMaxLength)]
        public string Suggestion { get; set; }

        public bool IsActive { get; set; }

        public ICollection<LessonMaterial> Materials { get; set; } = new HashSet<LessonMaterial>();
    }
}
