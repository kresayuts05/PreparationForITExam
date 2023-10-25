using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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

        [Required]
        public string Title { get; set; }

        [Required]
        public string ShortDescription { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime PostedOn { get; set; }

        public bool IsActive { get; set; }

        public string UsefulUrl { get; set; }


        [DefaultValue(0)]
        public int Likes { get; set; }


        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }

        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
        public ICollection<Image> Images { get; set; } = new HashSet<Image>();
    }
}
