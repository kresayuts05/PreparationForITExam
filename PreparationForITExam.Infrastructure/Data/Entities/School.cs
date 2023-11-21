using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.SchoolConstraints;


namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class School
    {
        public School()
        {
            this.IsActive = true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(CitySchoolMaxLength)]
        public string  City { get; set; } = null!;

        public bool IsActive { get; set; }

        public ICollection<Student> Students { get; set; } = new HashSet<Student>();

        public ICollection<Teacher> Teachers { get; set; } = new HashSet<Teacher>();
    }
}
