using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Exception
{
    public static class GlobalExceptions
    {
        public const string RequiredInput = "Задължително поле! Моля въведете данни!";
        public const string InvalidEmail = "Невалиден имейл!";
        public const string InvalidPhoneNumber = "Невалиден телефонен номер!";

        public const string RequestDoesNotExistExceptionMessage = "Такова запитване не съществува!";

        public const string ConstructorDoesNotExistExceptionMessage = "Такъв строител не съществува!";
    }
}