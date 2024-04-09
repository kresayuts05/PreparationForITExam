using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Profile;
using PreparationForITExam.Core.Models.User;
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
        private readonly IStudentService studentService;
        private readonly ITeacherService teacherService;
        private readonly IMonUserService monUserService;

        public UserService(IRepository _repo,
            UserManager<User> _userManager,
             IStudentService _studentService,
            ITeacherService _teacherService,
            IMonUserService _monUserService)
        {
            repo = _repo;
            userManager = _userManager;
            studentService = _studentService;
            teacherService = _teacherService;
            monUserService = _monUserService;
        }

        public async Task DeleteUser(string id)
        {
            var user = await repo.All<User>()
                .Where(u => u.Id == id)
                .FirstOrDefaultAsync();

            if (user.RoleName == "Student")
            {
                await studentService.DeleteStudent(id);
            }
            else if (user.RoleName == "Teacher")
            {
                await teacherService.DeleteTeacher(id);
            }
            else // MonUser
            {
                await monUserService.DeleteMonUser(id);
            }

            user.IsActive = false;

            await repo.SaveChangesAsync();
        }

        public Task<List<UserModel>> GetAllUsers(int page)
        {
            var model = repo.AllReadonly<User>()
                .Where(u => u.IsActive == true)
                .OrderByDescending(p => p.Id)
                .Skip(9 * ((int)(page == 0 ? 1 : page) - 1))
                .Take(9)
                .Select(u => new UserModel
                {
                    Id = u.Id,
                    Name = u.FirstName + " " + u.LastName,
                    ProfilePictureUrl = u.ProfilePictureUrl,
                    Role = u.RoleName,
                    City = u.City
                })
                .ToListAsync();

            return model;
        }

        public async Task<int> GetAllUsersCount()
        {
            var list = await repo.AllReadonly<User>()
                .Where (u => u.IsActive == true)
                .ToListAsync();

            return list.Count;
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
                RoleName = user.RoleName,
                City = user.City
                //put school
            };

            return model;
        }

        public async Task GiveRoleToTeacher(string id)
        {
            var user = await repo.All<User>()
                .Where(t => t.Id == id)
                .FirstOrDefaultAsync();

            await userManager.AddToRoleAsync(user, "Teacher");
            await repo.SaveChangesAsync();
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
