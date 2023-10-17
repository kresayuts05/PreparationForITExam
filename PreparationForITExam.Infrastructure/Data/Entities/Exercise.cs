using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Name { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey(nameof(Lesson))]
        public int LessonId { get; set; }

        public Lesson Lesson { get; set; }

        public ICollection<Material> Materials { get; set; } = new HashSet<Material>();
    }
}
