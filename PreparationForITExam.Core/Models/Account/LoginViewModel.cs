﻿using PreparationForITExam.Core.Exception;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = GlobalExceptions.RequiredInput)]
        [EmailAddress(ErrorMessage = GlobalExceptions.InvalidEmail)]
        public string Email { get; set; }

        [Required(ErrorMessage = GlobalExceptions.RequiredInput)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
