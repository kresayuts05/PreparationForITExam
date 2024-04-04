using System.ComponentModel.DataAnnotations;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.UserConstraints;
using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.SchoolConstraints;
using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.TeacherConstraints;
using Microsoft.AspNetCore.Http;
using PreparationForITExam.Core.Models.School;
using PreparationForITExam.Core.Exception;

namespace PreparationForITExam.Core.Models.Account
{
    public class RegisterViewModel
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


        [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = "Училището Ви трябва да е от {2} до {1} знака")]
        public string SchoolName { get; set; }


        [Range(ExperienceMinValue, ExperienceMaxValue, ErrorMessage = "Опитът Ви трябва да е от {2} до {1} години")]
        public int Experience { get; set; }


        [StringLength(SubjectMaxLength, MinimumLength = SubjectMinLength, ErrorMessage = "Предметът Ви трябва да е от {2} до {1} знака")]
        public string? Subject { get; set; } = null!;

        public IFormFile? ProfilePicture { get; set; }

        public Dictionary<string, List<SchoolModel>> SchoolsCities { get; set; } = new Dictionary<string, List<SchoolModel>>();
    }
}
