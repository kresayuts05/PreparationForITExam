using Microsoft.AspNetCore.Http;
using PreparationForITExam.Core.Exception;
using PreparationForITExam.Core.Models.School;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.UserConstraints;

namespace PreparationForITExam.Core.Models.MonUser
{
    public class MonUserViewModel
    {
        [Required(ErrorMessage = GlobalExceptions.RequiredInput)]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength, ErrorMessage = "Името Ви трябва да е от {2} до {1} символа")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = GlobalExceptions.RequiredInput)]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength, ErrorMessage = "Фамилията Ви трябва да е от {2} до {1} символа")]

        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = GlobalExceptions.RequiredInput)]
        [EmailAddress(ErrorMessage = GlobalExceptions.InvalidEmail)]
        [StringLength(EmailMaxLength, MinimumLength = EmailMinLength, ErrorMessage = "Имейла Ви трябва да е от {2} до {1} знака")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = GlobalExceptions.RequiredInput)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = GlobalExceptions.RequiredInput)]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string PasswordRepeat { get; set; } = null!;

        [Phone(ErrorMessage = GlobalExceptions.InvalidPhoneNumber)]
        public string PhoneNumber { get; set; } = null!;

        [StringLength(CityMaxLength, MinimumLength = CityMinLength)]
        public string City { get; set; }

        [StringLength(AboutMeMaxLength, MinimumLength = AboutMeMinLength, ErrorMessage = "Информацията за Вас трябва да е от {2} до {1} знака")]
        public string? AboutMe { get; set; }

        public IFormFile? ProfilePicture { get; set; }

        public Dictionary<string, List<SchoolModel>> SchoolsCities { get; set; } = new Dictionary<string, List<SchoolModel>>();
    }
}
