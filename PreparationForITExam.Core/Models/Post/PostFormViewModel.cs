using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.PostConstraints;
using Microsoft.AspNetCore.Http;
using PreparationForITExam.Core.Exception;

namespace PreparationForITExam.Core.Models.Post
{
    public class PostFormViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = GlobalExceptions.RequiredInput)]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength, ErrorMessage = "Заглавието трябва да е от {2} до {1} знака")]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = GlobalExceptions.RequiredInput)]
        [StringLength(ShortDescriptionMaxLength, MinimumLength = ShortDescriptionMinLength, ErrorMessage = "Краткото описание трябва да е от {2} до {1} знака")]
        public string ShortDescription { get; set; } = null!;

        [Required(ErrorMessage = GlobalExceptions.RequiredInput)]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength, ErrorMessage = "Описанието трябва да е от {2} до {1} знака")]
        public string Description { get; set; } = null!;

        public string? UsefulUrl { get; set; }

        public string UserId { get; set; }

        public List<IFormFile>? Images { get; set; } 

        public bool IsItQuestion { get; set; }
    }
}   
