using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.PostConstraints;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class Post
    {
        public Post()
        {
            this.IsActive = true;
            this.PostedOn = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        //Property for the title
        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        //Property for the schortDescription. It is displayed in the forum before seeing the full information about the post
        [Required]
        [MaxLength(ShortDescriptionMaxLength)]
        public string ShortDescription { get; set; } = null!;

        //Property for long description. It is displayed when seeing the full info
        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        //Property for date od creation
        public DateTime PostedOn { get; set; }

        //Property for status
        public bool IsActive { get; set; }

        //Property for indication and filtration. True if it is a question and false if it is a post
        public bool IsItQuestion { get; set; }

        //Property for userful links for documentation, files, anouther aplication and other
        public string? UsefulUrl { get; set; }

        //Property for the creator. 
        //One to many connection
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }

        //Property that is collection of all the comments bellow the post.
        // Many to one connection
        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();

        //Property that is collection of all the images int the post.
        // Many to one connection
        public ICollection<Image> Images { get; set; } = new HashSet<Image>();
    }
}
