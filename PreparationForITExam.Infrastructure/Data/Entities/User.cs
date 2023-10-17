using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class User : IdentityUser
    {
        public User()
        {
            this.IsActive = true;
        }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string City { get; set; }

        public string? ProfilePictureUrl { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Post> Posts { get; set; } = new HashSet<Post>();
        public ICollection<Material> Materials { get; set; } = new HashSet<Material>();
    }
}
