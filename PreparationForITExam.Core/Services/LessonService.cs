using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Lesson;
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
    public class LessonService : ILessonService
    {
        private readonly IRepository repo;
        private readonly ILessonCommentService questionService;
        private readonly IMaterialService materialService;

        public LessonService(IRepository _repo,
           ILessonCommentService _questionService,
           IMaterialService _materialService)
        {
            repo = _repo;
            questionService = _questionService;
            materialService = _materialService;
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
                    HasPresentation = l.Materials.Any(),
                })
                .ToListAsync();

            return lessons;
        }

        public async Task<LessonViewModel> GetLessonById(int id)
        {
            var lesson = await repo.AllReadonly<Lesson>()
                .Where(l => l.Id == id && l.IsActive == true)
                .Select( l => new LessonViewModel
                {
                    Id = l.Id,
                    Title = l.Title,
                    Module = l.SectionOfCurricular.ModuleOfCurricular.Title,
                    SectionOfCurricular = l.SectionOfCurricular.Title                    
                })
                .FirstOrDefaultAsync();

            lesson.PresentationUrl = await materialService.GetPresentationUrlByLessonId(id);
            lesson.Questions = await questionService.GetAllLessonCommentsByLessonId(id);
            lesson.Materials = await materialService.GetAllMaterialsForLessonById(id);

            return lesson;
        }

        public async Task<int> GetLessonByMaterialId(int id)
        {
            var material = await repo.GetByIdAsync<LessonMaterial>(id);

            return material.LessonId;
        }

        public async Task<string> GetLessonNameById(int id)
        {
            var lesson = await repo.GetByIdAsync<Lesson>(id);

            return lesson.Title;
        }

        public async Task<int> GetSectionCurricularIdByLessonId(int id)
        {
            var lesson = await repo.GetByIdAsync<Lesson>(id);

            return lesson.SectionOfCurricularId;
        }

        public async Task SetContentToLesson(string content, int id)
        {
            var lesson = await repo.GetByIdAsync<Lesson>(id);

            lesson.Content= content;
            await repo.SaveChangesAsync();
        }


    }
}
