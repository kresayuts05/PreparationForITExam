using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class QuestionAnswer
    {
        public QuestionAnswer()
        {
            IsActive = true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Value { get; set; } = null!;

        public bool IsActive { get; set; }

        [Required]
        [ForeignKey(nameof(Question))]
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
