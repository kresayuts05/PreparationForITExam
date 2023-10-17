using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Material> Materials { get; set; }
    }
}
