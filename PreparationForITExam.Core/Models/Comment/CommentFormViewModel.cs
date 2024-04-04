using Microsoft.AspNetCore.Http;
using PreparationForITExam.Core.Exception;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.Comment
{
    public class CommentFormViewModel
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public int PostId { get; set; }

        [Required(ErrorMessage = GlobalExceptions.RequiredInput)]
        public string Content { get; set; }

        public List<IFormFile> Images { get; set; }
    }
}
