using PreparationForITExam.Core.Models.Account;
using PreparationForITExam.Core.Models.Teacher;
using PreparationForITExam.Core.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface ITeacherService
    {
        Task Create(string userId, RegisterViewModel model, int schoolId);

        Task<int> GetTeacherIdByUserId(string id);

        Task<List<UserModel>> GetAllTeachers();

        Task DeleteTeacher(string userId);

        Task<List<TeacherModel>> GetAllTeachersWithStatusWaiting();

        Task DeclineTeacherRole(int id);

        Task ApproveTeacher(string id);
    }
}
