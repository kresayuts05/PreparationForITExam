using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class Material
    {
        public Material()
        {
            this.IsActive = true;
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        public string UrlPath { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey(nameof(Lesson))]
        public int LessonId { get; set; }

        public Lesson Lesson { get; set; }

        [ForeignKey(nameof(Exercise))]
        public int ExerciseId { get; set; }

        public Exercise Exercise { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }

    }
}
