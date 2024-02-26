using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.Answer
{
    public class AnswerModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? FileFormat { get; set; }

        public string UserId { get; set; }

        public string? UserName { get; set; }

        public string UrlPath { get; set; }

        public bool IsActive { get; set; }

        public int ExerciseMaterialId { get; set; }
    }
}
