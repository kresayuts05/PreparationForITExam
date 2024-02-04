using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.ExerciseConstraints;


namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class Exercise
    {
        public Exercise()
        {
            this.IsActive = true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; }

        public bool IsActive { get; set; }

        public ICollection<LessonQuestion> Questions { get; set; } = new HashSet<LessonQuestion>();

        public ICollection<Material> Materials { get; set; } = new HashSet<Material>();

        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
