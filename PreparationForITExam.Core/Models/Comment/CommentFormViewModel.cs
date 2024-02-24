using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.Comment
{
    public class CommentFormViewModel
    {
        public string UserId { get; set; }

        public int PostId { get; set; }

        public string Content { get; set; }

        public List<IFormFile> Images { get; set; }
    }
}
