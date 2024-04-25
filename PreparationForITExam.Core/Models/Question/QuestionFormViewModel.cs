using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PreparationForITExam.Core.Models.QuestionCategory;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Http;

namespace PreparationForITExam.Core.Models.Question
{
    public class QuestionFormViewModel
    {
        public string Description { get; set; }

        public IFormFile? Image { get; set; }
        public string RightAnswer { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public bool IsActive { get; set; }

        public bool IsFreeAnswer { get; set; }

        public int CategoryId { get; set; }

        public string UserId { get; set; }

        public List<QuestionCategoryModel> Categories { get; set; }
    }
}
