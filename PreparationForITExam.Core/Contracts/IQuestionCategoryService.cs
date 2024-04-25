using PreparationForITExam.Core.Models.QuestionCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface IQuestionCategoryService
    {
        Task<List<QuestionCategoryModel>> GetAllCategories();

        Task<List<int>> GetQuestionsIdsCountByCategoryId(int id);
    }
}
