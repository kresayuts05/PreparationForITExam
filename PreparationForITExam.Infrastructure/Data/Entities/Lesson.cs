using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Title { get; set; }

        public string Group { get; set; }

        public bool IsActive { get; set; }


        [ForeignKey(nameof(Exercise))]
        public int ExerciseId { get; set; }

        public Exercise Exercise { get; set; }

        public ICollection<Teacher> Teachers { get; set; } = new HashSet<Teacher>();
        public ICollection<Mon> Mons { get; set; } = new HashSet<Mon>();
        public ICollection<Material> Materials { get; set; } = new HashSet<Material>();
    }
}
