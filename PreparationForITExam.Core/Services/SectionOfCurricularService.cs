using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.SectionOfCurricular;
using PreparationForITExam.Infrastructure.Data.Common;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Services
{
    public class SectionOfCurricularService : ISectionOfCurricularService
    {
        private readonly IRepository repo;
        private readonly IModuleOfCurricularService moduleOfCurricularService;

        public SectionOfCurricularService(IRepository _repo,
            IModuleOfCurricularService _moduleOfCurricularService)
        {
            repo = _repo;
            this.moduleOfCurricularService = _moduleOfCurricularService;
        }

        public async Task<List<List<SectionOfCurricularViewModel>>> GetAllSectionsOfModule()
        {
            var sections = new List<List<SectionOfCurricularViewModel>>();

            var section = new List<SectionOfCurricularViewModel>();

            for (int i = 1; i < 5; i++)
            {
                section = await repo.All<SectionOfCurricular>()
                    .Where(s => s.ModuleOfCurricularId == i)
                    .Select(s => new SectionOfCurricularViewModel
                    {
                        Id = s.Id,
                        Title = s.Title,
                        Lessons = s.Lessons.Count,
                        Exercises = s.Exercises.Count,
                        ModuleOfCurricularId = s.ModuleOfCurricularId
                    })
                    .ToListAsync();

                sections.Add(section);
            }

            return sections;
        }

        public async Task<List<string>> GetTitleAndModuleOfSectionOfCurricularById(int id)
        {
            var section= await repo.GetByIdAsync<SectionOfCurricular>(id);
            List<string> list = new List<string>();
            list.Add(section.Title);
            list.Add(await moduleOfCurricularService.GetTitleByModuleOCurricularId(section.ModuleOfCurricularId));

            return list;
        }
    }
}
