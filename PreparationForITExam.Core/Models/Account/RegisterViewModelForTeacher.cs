using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.Account
{
    using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.UserConstraints;
    using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.SchoolConstraints;
    using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.TeacherConstraints;

    public class RegisterViewModelForTeacher
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

        [Required]
        [StringLength(CityMaxLength, MinimumLength = CityMinLength)]
        public string City { get; set; }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string SchoolName { get; set; }

        
        [Range(ExperienceMinValue, ExperienceMaxValue)]
        public int Experience { get; set; }

        
        [StringLength(SubjectMaxLength, MinimumLength = SubjectMinLength)]
        public string? Subject { get; set; } = null!;

        public IFormFile? ProfilePicture { get; set; }
    }
}
