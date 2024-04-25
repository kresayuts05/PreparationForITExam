using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.QuestionCategory;
using PreparationForITExam.Infrastructure.Data.Common;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Services
{
    public class QuestionCategoryService : IQuestionCategoryService
    {
        private readonly IRepository repo;

        public QuestionCategoryService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<List<QuestionCategoryModel>> GetAllCategories()
        {
            var categories = await repo.AllReadonly<QuestionCategory>()
                .Select(s => new QuestionCategoryModel
                {
                    Id = s.Id,
                    Name = s.Name,
                })
                .ToListAsync();

            return categories;
        }

        public async Task<List<int>> GetQuestionsIdsCountByCategoryId(int id)
        {
            var ids = await repo.AllReadonly<Question>()
                .Where(q => q.CategoryId == id)
                .Select(q => q.Id)
                .ToListAsync();

            return ids;
        }
    }
}
