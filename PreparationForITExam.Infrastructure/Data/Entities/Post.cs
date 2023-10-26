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

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(ShortDescriptionMaxLength)]
        public string ShortDescription { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        public DateTime PostedOn { get; set; }

        public bool IsActive { get; set; }

        public string UsefulUrl { get; set; }

        [DefaultValue(0)]
        public int Likes { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }

        public ICollection<PostComment> Comments { get; set; } = new HashSet<PostComment>();
        public ICollection<Image> Images { get; set; } = new HashSet<Image>();
    }
}
