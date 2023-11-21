﻿using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Infrastructure.Data.Common;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository repo;

        public StudentService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task Create(string userId)
        {
            var student = new Student()
            {
                UserId = userId,
            };

            await repo.AddAsync(student);
            await repo.SaveChangesAsync();
        }
    }
}
