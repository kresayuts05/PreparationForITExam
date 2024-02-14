using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.QuestionConstraints;


namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class LessonComment
    {
        public LessonComment()
        {
            this.IsActive= true;
            CreatedOn = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(QuestionMaxLength)]
        public string Content { get; set; }

        public bool IsActive { get; set; }


        [ForeignKey(nameof(Lesson))]
        public int LessonId { get; set; }

        public Lesson Lesson { get; set; }


        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public User User { get; set; }

        public string? Url { get; set; }

        public DateTime CreatedOn { get; set; }

    }
}
