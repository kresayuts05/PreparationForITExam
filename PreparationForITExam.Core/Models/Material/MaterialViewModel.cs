using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.Material
{
    public class MaterialViewModel
    {
        public int LessonId { get; set; }

        public IFormFile FileInfo { get; set; }
    }
}
