using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Exercise;
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
    public class ExerciseService : IExerciseService
    {
        private readonly IRepository repo;
        private readonly IMaterialService materialService;

        public ExerciseService(
            IRepository _repo,
            IMaterialService _materialService)
        {
            repo = _repo;
            materialService = _materialService;
        }

        public async Task<List<ExerciseModel>> GetAllExercisesBySectionOfCurricularId(int sectionId)
        {
            var exercises = await repo.All<Exercise>()
                .Where(l => l.SectionOfCurricularId == sectionId && l.IsActive == true)
                .Select(l => new ExerciseModel
                {
                    Id = l.Id,
                    SectionOfCurricularId = l.SectionOfCurricularId,
                    Title = l.Title,
                    HasMainDocument = l.Materials.Any(),
                })
                .ToListAsync();

            return exercises;
        }

        public async  Task<ExerciseViewModel> GetExerciseById(int id)
        {
            var exercise = await repo.AllReadonly<Exercise>()
                .Where(l => l.Id == id && l.IsActive == true)
                .Select(l => new ExerciseViewModel
                {
                    Id = l.Id,
                    Title = l.Title,
                    Module = l.SectionOfCurricular.ModuleOfCurricular.Title,
                    SectionOfCurricular = l.SectionOfCurricular.Title,
                    Content = l.Content
                })
                .FirstOrDefaultAsync();

            exercise.DocumentURL = await materialService.GetDocumentUrlByExerciseId(id);
            exercise.Materials = await materialService.GetAllMaterialsForExerciseById(id);

            return exercise;
        }

        public async  Task<int> GetExerciseByMaterialId(int id)
        {

            var material = await repo.GetByIdAsync<ExerciseMaterial>(id);

            return material.ExerciseId;
        }

        public async Task SetContentToExercise(string content, int id)
        {
            var exercise = await repo.GetByIdAsync<Exercise>(id);

            exercise.Content = content;
            await repo.SaveChangesAsync();
        }
    }
}
