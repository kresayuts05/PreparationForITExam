using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class News
    {
        public News()
        {
            this.IsActive= true;
            this.PostedOn= DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Mon))]
        public int MonId { get; set; }
        public Mon Mon { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [DefaultValue(0)]
        public int SeenByPeople { get; set; }

        public DateTime PostedOn { get; set; }

        public bool IsActive { get; set; }

        public ICollection<string> UsefulUrls { get; set; } = new HashSet<string>();

        public ICollection<Material> Materials { get; set; } = new HashSet<Material>();
        public ICollection<Image> Images { get; set; } = new HashSet<Image>();
    }
}
