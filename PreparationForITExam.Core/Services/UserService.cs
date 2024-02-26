using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Profile;
using PreparationForITExam.Infrastructure.Data.Common;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository repo;
        private readonly UserManager<User> userManager;

        public UserService(IRepository _repo,
            UserManager<User> _userManager)
        {
            repo = _repo;
            userManager = _userManager;
        }

        public async Task<ProfileViewModel> GetUserInfo(string id)
        {
            var user = await repo.GetByIdAsync<User>(id);

            var model = new ProfileViewModel
            {
                ProfilePicture = user.ProfilePictureUrl,
                Name = user.FirstName + " " + user.LastName,
                Email = user.Email,
                Phone = user.PhoneNumber,
                AboutMe = user.AboutMe,
                RoleName = user.RoleName
            };

            return model;
        }

        public async Task<bool> UserByEmailExists(string email)
        {
            var user = await repo.All<User>()
                .FirstOrDefaultAsync(u => u.Email == email && u.IsActive == true);

            return user != null;
        }

        public async Task<string> UserNameById(string id)
        {
            var user = await repo.GetByIdAsync<User>(id);

            return user.FirstName + " " + user.LastName;
        }
    }
}
