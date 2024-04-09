using PreparationForITExam.Core.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface IMonUserService
    {
        Task<int> GetMonUserIdByUserId(string userId);

        Task<List<UserModel>> GetAllMonUsers();

        Task DeleteMonUser(string userId);

        Task Create(string userId);
    }
}
