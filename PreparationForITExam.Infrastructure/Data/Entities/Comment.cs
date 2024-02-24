using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.QuestionConstraints;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class Comment
    {
        public Comment()
        {
            this.IsActive = true;
            CreatedOn = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(QuestionMaxLength)]
        public string Content { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public User User { get; set; }

        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }

        public Post Post { get; set; }

        public ICollection<ImageComment> Images { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
