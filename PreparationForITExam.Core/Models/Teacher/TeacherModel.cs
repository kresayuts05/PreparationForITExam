using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.Teacher
{
    //This model is used for displaying teacher information in the admin area. 
    public class TeacherModel
    {
        public string UserId { get; set; }

        public int TeacherId { get; set; }

        public string Name { get; set; }

        public string ProfilePictureUrl { get; set; }

        public string Role { get; set; }

        public string City { get; set; }

        public string SchoolName { get; set; }

        public int Experience { get; set; }
        public string CreatedOn { get; set; }
        
        public string? Subject { get; set; }

        public string? AboutMe { get; set; }
    }
}
