using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class Student
    {
        public Student()
        {
            this.IsActive = true;
        }

        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(School))]
        public int SchoolId { get; set; }
        public School School { get; set; }

        public string Speciality { get; set; }

        public int Grade { get; set; }

        public string AboutMe { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Exercise> FinishedExercises { get; set; } = new HashSet<Exercise>();
    }
}
