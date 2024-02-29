using PreparationForITExam.Core.Models.Answer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.Material
{
    public class MaterialModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? FileFormat { get; set; }

        public string UserId { get; set; }

        public string? UserName { get; set; }

        public string UrlPath { get; set; }

        public bool IsActive { get; set; }

        public int LessonId { get; set; }

        public bool IsExercise { get; set; }
        public bool IsItStudentMaterial { get; set; }

        public List<AnswerModel> Answers { get; set; }
    }
}
