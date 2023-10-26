using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.LessonConstraints;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class Lesson
    {
        public Lesson()
        {
            this.IsActive = true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [MaxLength(GroupMaxLength)]
        public string Group { get; set; }

        [Required]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey(nameof(Exercise))]
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }

        [Required]
        public ICollection<MonUser> Mons { get; set; } = new HashSet<MonUser>();
        public ICollection<Teacher> Teachers { get; set; } = new HashSet<Teacher>();
        public ICollection<Material> Materials { get; set; } = new HashSet<Material>();
    }
}
