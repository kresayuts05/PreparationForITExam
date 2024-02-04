using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.QuestionConstraints;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class ExerciseQuestion
    {
        public ExerciseQuestion()
        {
            this.IsActive = true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(QuestionMaxLength)]
        public string QuestionContent { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; }

        public bool IsActive { get; set; }


        [ForeignKey(nameof(Exercise))]
        public int ExerciseId { get; set; }

        public Exercise Exercise { get; set; }


        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public User User { get; set; }
    }
}
