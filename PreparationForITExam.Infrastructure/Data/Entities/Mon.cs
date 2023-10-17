using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Infrastructure.Data.Entities
{
    public class Mon
    {
        public Mon()
        {
            this.IsActive= true;
        }

        [Key]
        public int Id { get; set; }

        public bool IsActive { get; set; }

        public ICollection<News> News { get; set; }
        public ICollection<Material> Materials { get; set; }
    }
}
