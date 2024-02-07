using System.ComponentModel.DataAnnotations;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.UserConstraints;
using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.SchoolConstraints;
using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.TeacherConstraints;
using Microsoft.AspNetCore.Http;
using PreparationForITExam.Core.Models.School;

namespace PreparationForITExam.Core.Models.Account
{
    public class RegisterViewModel
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

        [Phone]
        public string PhoneNumber { get; set; } = null!;

        [StringLength(CityMaxLength, MinimumLength = CityMinLength)]
        public string? City { get; set; }

        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string? SchoolName { get; set; }


        [Range(ExperienceMinValue, ExperienceMaxValue)]
        public int Experience { get; set; }


        [StringLength(SubjectMaxLength, MinimumLength = SubjectMinLength)]
        public string? Subject { get; set; } = null!;

        public IFormFile? ProfilePicture { get; set; }

        public Dictionary<string, List<SchoolModel>> SchoolsCities { get; set; } = new Dictionary<string, List<SchoolModel>>();
    }
}
