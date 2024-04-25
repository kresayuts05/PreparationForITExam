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
    //This entity represents a user. It is extended version of the identity user because it contains more informatin. 
    public class User : IdentityUser
    {
        // When instanced every user is with status is active true and date od registration the current date
        public User()
        {
            this.IsActive = true;
            CreatedOn = DateTime.UtcNow;
        }

        //Property for first name of user
        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        //Property for last name of user
        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        //Property for the city of the user. It can be null.
        [MaxLength(CityMaxLength)]
        public string? City { get; set; }

        //Property for additional information about the user. It can be null
        [MaxLength(AboutMeMaxLength)]
        public string? AboutMe { get; set; }

        //Property for the date od registration
        public DateTime CreatedOn { get; set; }

        //Property containing the role name of the current user
        public string RoleName { get; set; }

        //Property for the url of the profile picture of user. It can be null
        public string? ProfilePictureUrl { get; set; }

        //Property for the status of User. If is true it means that the user is active. 
        //When changed to false it means that the user is "deleted"
        public bool IsActive { get; set; }

        //Property that is collection of all the posts created by the user. It represents the connection many to one between entities
        public ICollection<Post> Posts { get; set; } = new HashSet<Post>();

        //Property that is collection of all the materials the user has. It is for lesson materials. Many to one connection
        public ICollection<LessonMaterial> Materials { get; set; } = new HashSet<LessonMaterial>();

        //Property that is collection of all reviews the user has made. Connection many to one
        public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();

        //Property that is collection of all questions the user has made. Connection one to many
        public ICollection<Question> Questions { get; set; } = new HashSet<Question>();

        //Property that is collection of all test scores the user has. Connection many to one
        public ICollection<TestScore> TestScores { get; set; } = new HashSet<TestScore>();
    }
}
