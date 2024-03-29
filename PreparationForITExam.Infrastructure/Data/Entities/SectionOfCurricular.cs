﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.SectionOfCurricularConstraints;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class SectionOfCurricular
    {
        public SectionOfCurricular()
        {
            this.IsActive = true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        public bool IsActive { get; set; }

        [Required]
        [ForeignKey(nameof(ModuleOfCurricular))]
        public int ModuleOfCurricularId { get; set; }

        public ModuleOfCurricular ModuleOfCurricular { get; set; }

        public ICollection<Lesson> Lessons { get; set; } = new HashSet<Lesson>();
        public ICollection<Exercise> Exercises { get; set; } = new HashSet<Exercise>();

        //public ICollection<Test> Tests { get; set; } = new HashSet<Test>();
    }
}
