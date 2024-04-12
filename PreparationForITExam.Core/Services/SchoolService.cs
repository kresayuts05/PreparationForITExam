using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Exception;
using PreparationForITExam.Core.Models.School;
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
                .Where(s => s.City == city)
                .Where(n => n.NormalizedName.Contains(schoolName.ToLower()))
                .Select(n => n.Id)
                .FirstOrDefaultAsync();

            return schoolId;
        }

        public async Task<List<SchoolModel>> AllSchools()
        {
            var allSchools = await repo.All<School>()
                .Select(s => new SchoolModel
                {
                    Id = s.Id,
                    Name = s.Name,
                    City = s.City,
                })
                .ToListAsync();

            return allSchools;
        }

        public async Task<Dictionary<string, List<SchoolModel>>> AllSchoolsWithCitiesAsDitionary()
        {
            var allSchools = await repo.All<School>()
                .Select(s => new SchoolModel
                {
                    Id = s.Id,
                    Name = s.Name,
                    City = s.City,
                })
                .ToListAsync();

            Dictionary<string, List<SchoolModel>> dic = new Dictionary<string, List<SchoolModel>>();

            var cities = allSchools.Select(s => s.City).Distinct().ToList();

            foreach (var city in cities)
            {
                dic.Add(city, allSchools.Where(s => s.City == city).ToList());
            }

            return dic;
        }
    }
}
