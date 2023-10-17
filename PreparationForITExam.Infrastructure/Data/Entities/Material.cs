using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class Material
    {
        public Material()
        {
            this.IsActive = true;
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        public string UrlPath { get; set; }

        public bool IsActive { get; set; }
    }
}
