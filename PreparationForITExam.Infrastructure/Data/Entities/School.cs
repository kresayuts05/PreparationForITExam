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

        //Propery for school name
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        //Property for normalized name
        [Required]
        [MaxLength(NameMaxLength)]
        public string NormalizedName { get; set; } = null!;

        //Property for the city in which the school is located
        [Required]
        [MaxLength(CitySchoolMaxLength)]
        public string  City { get; set; } = null!;

        //Property for status
        public bool IsActive { get; set; }

        //Property that is collection of all the students that are studying in this school.
        // Many to one connection

        public ICollection<Student> Students { get; set; } = new HashSet<Student>();

        //Property that is collection of all the teachers that are working in this school.
        // Many to one connection
        public ICollection<Teacher> Teachers { get; set; } = new HashSet<Teacher>();
    }
}
