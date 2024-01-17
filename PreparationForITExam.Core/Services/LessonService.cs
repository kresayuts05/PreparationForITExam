using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Lesson;
using PreparationForITExam.Infrastructure.Data.Common;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Services
{
    public class LessonService : ILessonService
    {
        private readonly IRepository repo;

        public LessonService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<List<LessonModel>> AllLessonsBySectionOfCurricularId(int sectionId)
        {
            var lessons = await repo.All<Lesson>()
                .Where(l => l.SectionOfCurricularId == sectionId && l.IsActive == true)
                .Select(l => new LessonModel
                {
                    Id = l.Id,
                    SectionOfCurricularId = l.SectionOfCurricularId,
                    Title = l.Title,

                })
                .ToListAsync();

            return lessons;
        }
    }
}
