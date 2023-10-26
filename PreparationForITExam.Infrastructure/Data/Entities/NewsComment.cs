using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.CommentConstraints;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class NewsComment
    {
        public NewsComment()
        {
            this.IsActive = true;
            this.PostedOn = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; } = null!;

        public DateTime PostedOn { get; set; }

        [DefaultValue(0)]
        public int Likes { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
