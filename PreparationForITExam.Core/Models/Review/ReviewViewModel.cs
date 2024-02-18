using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.Review
{
    public class ReviewViewModel
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int Stars { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public string UserProfileUrl { get; set; }

        public string RoleName { get; set; }
    }
}
