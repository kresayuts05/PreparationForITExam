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

namespace PreparationForITExam.Core.Models.Question
{
    public class LessonCommentFormViewModel
    {
        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; }

        [Required]
        [StringLength(QuestionMaxLength, MinimumLength = QuestionMinLength)]
        public string Content { get; set; }

        public int LessonId { get; set; }

        public string UserId { get; set; }

        public string? Url { get; set; }

    }
}
