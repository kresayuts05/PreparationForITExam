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
    public class SchoolService : ISchoolService
    {
        private readonly IRepository repo;

        public SchoolService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<int> GetSchoolByNameAndCity(string schoolName, string city)
        {
            var schoolId = await repo.All<School>()
                .Where(s => s.Name.ToLower() == schoolName.ToLower() && s.City == city)
                .Select(s => s.Id)
                .FirstOrDefaultAsync();

            return schoolId;
        }
    }
}
