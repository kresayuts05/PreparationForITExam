﻿using Microsoft.EntityFrameworkCore;
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
    public class UserService:IUserService
    {
        private readonly IRepository repo;

        public UserService(IRepository _repo)
        {
            repo = _repo;
        }
        
        public async Task<bool> UserByEmailExists(string email)
        {
            var user = await repo.All<User>()
                .FirstOrDefaultAsync(u => u.Email == email && u.IsActive == true);

            return user != null;
        }
    }   
}
