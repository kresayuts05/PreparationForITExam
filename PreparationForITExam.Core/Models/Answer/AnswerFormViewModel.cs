using Microsoft.AspNetCore.Http;
using PreparationForITExam.Core.Exception;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.LessonConstraints;

namespace PreparationForITExam.Core.Models.Answer
{
    public class AnswerFormViewModel
    {
        public int ExerciseMaterialId { get; set; }

        public int ExerciseId { get; set; }

        public string UserId { get; set; }

        [Required(ErrorMessage = GlobalExceptions.RequiredInput)]
        [StringLength(ContentMaxLength, MinimumLength = ContentMinLength, ErrorMessage = "Информацията трябва да е от {2} до {1} знака")]
        public string? Content { get; set; }

        public IFormFile FileInfo { get; set; }

        public List<IFormFile> Documents { get; set; }
    }
}
