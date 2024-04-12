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
    //Entity that represents all teachers. It is created for users with role teacher. It contains additional information 
    //specific for teachers
    public class Teacher
    {
        //When instanced every teacher is with status waiting. It can be changed by the administrator.
        //Property is active is set to true
        public Teacher()
        {
            this.IsActive = true;
            this.Status = "Waiting";
        }

        [Key]
        public int Id { get; set; }

        [Range(ExperienceMinValue, ExperienceMaxValue)]
        public int Experience { get; set; }

        [MaxLength(SubjectMaxLength)]
        public string? Subject { get; set; }

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
