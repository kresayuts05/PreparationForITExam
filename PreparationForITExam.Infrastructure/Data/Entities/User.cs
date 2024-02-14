using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.UserConstraints;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class User : IdentityUser
    {
        public User()
        {
            this.IsActive = true;
        }

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [MaxLength(CityMaxLength)]
        public string? City { get; set; }

        [MaxLength(AboutMeMaxLength)]
        public string? AboutMe { get; set; }

        public string RoleName { get; set; }

        public string? ConnectionId { get; set; }

        public string? ProfilePictureUrl { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Post> Posts { get; set; } = new HashSet<Post>();

        public ICollection<LessonMaterial> Materials { get; set; } = new HashSet<LessonMaterial>();

        public ICollection<Message> Messages { get; set; } = new HashSet<Message>();

        public ICollection<LessonComment> LessonComments { get; set; } = new HashSet<LessonComment>();
    }
}
