using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Exception;
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
    //UserService contains buisness logic about all functionality with users entity therefore all registered users. 
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

        //This method "delete" certain user. It actually deactivate it by setting property's value IsActive = false
        public async Task DeleteUser(string id)
        {
            var user = await repo.All<User>()
                .Where(u => u.Id == id)
                .FirstOrDefaultAsync();

            if (user == null || user.IsActive == false)
            {
                throw new NullReferenceException(GlobalExceptions.UserDoesNotExistExceptionMessage);
            }

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

        //This method returns a collection of UserModel. It is used for displaying users in the admin panel.
        //It has parameter page which is used for pagination
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

        //This method returns the count of all active users
        //It is used for pagination
        public async Task<int> GetAllUsersCount()
        {
            var list = await repo.AllReadonly<User>()
                .Where (u => u.IsActive == true)
                .ToListAsync();

            return list.Count;
        }

        //This method returns ProvileViewModel in which is contained all information about the wanted user. 
        //It is used when displaying information in profile page
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

        //This method assigns teacher role to certain user
        //It is used by the administrator
        public async Task GiveRoleToTeacher(string id)
        {
            var user = await repo.All<User>()
                .Where(t => t.Id == id)
                .FirstOrDefaultAsync();

            await userManager.AddToRoleAsync(user, "Teacher");
            await repo.SaveChangesAsync();
        }

        //This method checks if there is a user with certain email
        public async Task<bool> UserByEmailExists(string email)
        {
            var user = await repo.All<User>()
                .FirstOrDefaultAsync(u => u.Email == email && u.IsActive == true);

            return user != null;
        }

        //This method returns the full name of user by the id
        public async Task<string> UserNameById(string id)
        {
            var user = await repo.GetByIdAsync<User>(id);

            return user.FirstName + " " + user.LastName;
        }
    }
}
