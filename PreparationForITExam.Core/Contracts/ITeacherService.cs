using PreparationForITExam.Core.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface ITeacherService
    {
        Task Create(string userId, RegisterViewModelForTeacher model);
    }
}
