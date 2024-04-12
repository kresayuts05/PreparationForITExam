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

        public const string UserDoesNotExistExceptionMessage = "Не съществува такъв потребител!";

        public const string TeacherDoesNotExistExceptionMessage = "Не съществува такъв учител!";
        public const string StudentDoesNotExistExceptionMessage = "Не съществува такъв ученик!";
        public const string SchoolDoesNotExistExceptionMessage = "Не съществува такова училище!";
        public const string PostDoesNotExistExceptionMessage = "Не съществува такъв пост!";
    }
}