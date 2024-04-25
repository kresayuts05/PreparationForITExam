using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Infrastructure.Data.Entities
{

    public class Question
    {
        public Question()
        {
           IsActive = true;
           IsFreeAnswer = true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        public string? Image { get; set; }

        [Required]
        public string  RightAnswer{ get; set; }

        [Required]
        public ICollection<QuestionAnswer> Answers { get; set; }
        public bool IsActive { get; set; }
        public bool IsFreeAnswer { get; set; }

        [Required]
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public QuestionCategory Category { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
