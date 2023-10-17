using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class Teacher
    {
        public Teacher()
        {
            this.IsActive= true;
            this.Status = "Waiting";
        }

        [Key]
        public int Id { get; set; }

        public string Experience { get; set; }

        public string Subject { get; set; }

        public string University { get; set; }

        public string AboutMe { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }

        [Required]
        [ForeignKey(nameof(School))]
        public int SchoolId { get; set; }
        public School School { get; set; }

        public string Status { get; set; }

        public bool IsActive { get; set; }


    }
}
