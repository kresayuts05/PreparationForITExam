using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class MonUser
    {
        public MonUser()
        {
            this.IsActive= true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public User User { get; set; }

        public bool IsActive { get; set; }

        public ICollection<News> News { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}
