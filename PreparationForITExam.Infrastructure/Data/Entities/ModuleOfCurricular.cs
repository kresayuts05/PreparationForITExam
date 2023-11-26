using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.ModuleOfCurricularConstraints;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class ModuleOfCurricular
    {
        public ModuleOfCurricular()
        {
            this.IsActive = true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        public bool IsActive { get; set; }

        public ICollection<SectionOfCurricular> SectionsOfCurricular { get; set; } = new HashSet<SectionOfCurricular>();
    }
}
