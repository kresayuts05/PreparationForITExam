using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.NewsConstraints;

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

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [DefaultValue(0)]
        public int SeenByPeople { get; set; }

        public DateTime PostedOn { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [ForeignKey(nameof(Mon))]
        public int MonId { get; set; }
        public MonUser Mon { get; set; }

        public string? UsefulUrls { get; set; }
        public ICollection<Image> Images { get; set; } = new HashSet<Image>();
    }
}
