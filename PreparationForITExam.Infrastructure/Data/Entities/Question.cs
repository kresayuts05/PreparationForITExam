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
    public class Question
    {
        public Question()
        {
            this.IsActive= true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(QuestionMaxLength)]
        public string QuestionContent { get; set; }

        [Required]
        [MaxLength(CorrectAnswerMaxLength)]
        public string CorrectAnswer { get; set; }

        [Required]
        [MaxLength(WrongAnswerMaxLength)]
        public string WrongAnswers { get; set; }

        [Required]
        [Range(minimum: PointsMinValue, maximum: PointsMaxValue)]

        public int Points { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey(nameof(Test))]
        public int TestId { get; set; }

        public Test Test { get; set; }
    }
}
