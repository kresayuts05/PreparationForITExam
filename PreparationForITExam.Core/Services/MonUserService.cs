using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
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

        public async Task<int> GetMonUserIdByUserId(string userId)
        {
            var mon = await repo.AllReadonly<MonUser>()
                .Where(m => m.UserId == userId)
                .FirstOrDefaultAsync();

            return mon.Id ;
        }
    }
}
