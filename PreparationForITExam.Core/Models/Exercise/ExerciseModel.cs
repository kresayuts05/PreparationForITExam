using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.Exercise
{
    public class ExerciseModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int SectionOfCurricularId { get; set; }

        public bool HasMainDocument { get; set; }

        public string Content { get; set; }

        public bool IsActive { get; set; }
    }
}
