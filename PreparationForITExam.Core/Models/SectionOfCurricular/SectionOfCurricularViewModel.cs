using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.SectionOfCurricular
{
    public class SectionOfCurricularViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public int Lessons { get; set; }

        public int Exercises { get; set; }

        public bool IsActive { get; set; }

        public int ModuleOfCurricularId { get; set; }
    }
}
