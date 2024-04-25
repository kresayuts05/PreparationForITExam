using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.Question
{
    public class QuestionViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string? Image { get; set; }
        public string RightAnswer { get; set; }
        public List<string> Answers { get; set; }
        public bool IsActive { get; set; }
        public bool IsFreeAnswer { get; set; }
        public int CategoryId { get; set; }
        public string UserId { get; set; }
    }
}
