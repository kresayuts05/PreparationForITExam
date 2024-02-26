using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class Answer
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        [Required]
        public string UrlPath { get; set; } = null!;

        [Required]
        public string FileFormat { get; set; }

        public bool IsActive { get; set; }

        public bool IsStudentMaterial { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(ExerciseMaterial))]
        public int ExerciseMaterialId { get; set; }

        public ExerciseMaterial ExerciseMaterial { get; set; }
    }
}
