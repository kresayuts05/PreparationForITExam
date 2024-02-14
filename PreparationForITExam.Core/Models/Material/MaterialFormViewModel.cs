using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.LessonConstraints;

namespace PreparationForITExam.Core.Models.Material
{
    public class MaterialFormViewModel
    {
        public int LessonId { get; set; }
        public int SectionOfCurricularId { get; set; }

        [StringLength(ContentMaxLength, MinimumLength = ContentMinLength)]
        public string? Content { get; set; }

        public IFormFile FileInfo { get; set; }

        public List<IFormFile> Documents { get; set; } 
    }
}
