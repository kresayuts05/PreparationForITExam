using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.MaterialConstraints;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class ExerciseMaterial
    {
        public ExerciseMaterial()
        {
            this.IsActive = true;
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(NameMaxLength)]
        public string? Name { get; set; }

        [Required]
        public string UrlPath { get; set; } = null!;

        [Required]
        public string FileFormat { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(Exercise))]
        public int? ExerciseId { get; set; }

        public Exercise Exercise { get; set; }
    }
}
