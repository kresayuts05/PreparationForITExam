using PreparationForITExam.Infrastructure.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.TeacherConstraints;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class Teacher
    {
        public Teacher()
        {
            this.IsActive = true;
            this.Status = "Waiting";
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Range(ExperienceMinValue, ExperienceMaxValue)]
        public int Experience { get; set; }

        [Required]
        [MaxLength(SubjectMaxLength)]
        public string Subject { get; set; } = null!;

        [Required]
        [MaxLength(UniversityMaxLength)]
        public string University { get; set; } = null!;

        [MaxLength(AboutMeMaxLength)]
        public string AboutMe { get; set; }

        [EnumDataType(typeof(TeacherStatusEnum))]
        public string Status { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }

        [Required]
        [ForeignKey(nameof(School))]
        public int SchoolId { get; set; }
        public School School { get; set; }

        public ICollection<Lesson> Lessons { get; set; } = new HashSet<Lesson>();

        public ICollection<Exercise> Exercises { get; set; } = new HashSet<Exercise>();
    }
}
