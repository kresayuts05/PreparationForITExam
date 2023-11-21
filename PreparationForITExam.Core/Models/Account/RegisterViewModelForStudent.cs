using System.ComponentModel.DataAnnotations;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.UserConstraints;
using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.SchoolConstraints;
using Microsoft.AspNetCore.Http;

namespace PreparationForITExam.Core.Models.Account
{
    public class RegisterViewModelForStudent
    {

        [Required]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]

        public string LastName { get; set; } = null!;

        [Required]
        [EmailAddress]
        [StringLength(EmailMaxLength, MinimumLength = EmailMinLength)]
        public string Email { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string PasswordRepeat { get; set; } = null!;

        [Required]
        [Phone]
        public string PhoneNumber { get; set; } = null!;

        [StringLength(CityMaxLength, MinimumLength = CityMinLength)]
        public string? City { get; set; }

        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string? SchoolName { get; set; }

        public IFormFile? ProfilePicture { get; set; }
    }
}
