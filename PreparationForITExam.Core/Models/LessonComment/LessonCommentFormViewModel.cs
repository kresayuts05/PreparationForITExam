using Microsoft.SharePoint.WebPartPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.QuestionConstraints;
using PreparationForITExam.Core.Models.Lesson;
using PreparationForITExam.Core.Exception;

namespace PreparationForITExam.Core.Models.Question
{
    public class LessonCommentFormViewModel
    {
        [Required(ErrorMessage = GlobalExceptions.RequiredInput)]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength, ErrorMessage = "Заглавието трябва да е от {2} до {1} знака")]
        public string Title { get; set; }

        [Required(ErrorMessage = GlobalExceptions.RequiredInput)]
        [StringLength(QuestionMaxLength, MinimumLength = QuestionMinLength, ErrorMessage = "Информацията трябва да е от {2} до {1} знака")]
        public string Content { get; set; }

        public int LessonId { get; set; }

        public string UserId { get; set; }

        public string? Url { get; set; }

    }
}
