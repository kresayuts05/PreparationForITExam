using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
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
    public class MonUserService : IMonUserService
    {
        private readonly IRepository repo;

        public MonUserService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task Create(string userId)
        {
            var monUser = new MonUser()
            {
                UserId = userId
            };

            await repo.AddAsync(monUser);
            await repo.SaveChangesAsync();
        }

        public async Task DeleteMonUser(string userId)
        {
            var monUser = await repo.All<MonUser>()
                  .Where(t => t.UserId == userId)
                  .FirstOrDefaultAsync();

            monUser.IsActive = false;

            await repo.SaveChangesAsync();
        }

        public async Task<List<UserModel>> GetAllMonUsers ()
        {
            var model = await repo.AllReadonly<MonUser>()
                .Where(t => t.IsActive == true)
                .OrderByDescending(p => p.Id)
                .Select(t => new UserModel
                {
                    UserInRoleId = t.Id,
                    Id = t.UserId,
                    Name = t.User.FirstName + " " + t.User.LastName,
                    Role = "MonUser",
                    City = t.User.City,
                    ProfilePictureUrl = t.User.ProfilePictureUrl
                })
                .ToListAsync();

            return model;
        }

        public async Task<int> GetMonUserIdByUserId(string userId)
        {
            var mon = await repo.AllReadonly<MonUser>()
                .Where(m => m.UserId == userId)
                .FirstOrDefaultAsync();

            return mon.Id;
        }
    }
}
