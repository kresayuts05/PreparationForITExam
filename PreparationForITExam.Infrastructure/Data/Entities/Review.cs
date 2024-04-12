using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class Review
    {
        public Review()
        {
            IsActive= true;
        }

        [Key]
        public int Id { get; set; }

        //Property for grade. from 0 to 5
        [Required]
        [Range(0, 5)]
        public int Stars { get; set; }

        //Property for description of the user opinion about the application
        [Required]
        [MaxLength(250)]
        public string Description { get; set; }

        //Property for status
        public bool IsActive { get; set; }

        //Property for the creator of the review
        //Connection One to Many
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
