﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.StudentConstraints;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class Student
    {
        public Student()
        {
            this.IsActive = true;
            this.Grade = 0;
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(SpecialtyMaxLength)]
        public string? Speciality { get; set; } = null!;

        [Range(GradeMinValue, GradeMaxValue)]
        public int Grade { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(School))]
        public int SchoolId { get; set; }
        public School School { get; set; }

        public ICollection<Exercise> FinishedExercises { get; set; } = new HashSet<Exercise>();
    }
}
