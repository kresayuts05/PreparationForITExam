using Microsoft.Ajax.Utilities;
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
    public class QuestionAnswerService : IQuestionAnswerService
    {
        private readonly IRepository repo;

        public QuestionAnswerService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task Add(string value, int questionId)
        {
            QuestionAnswer answer = new QuestionAnswer()
            {
                Value = value,
                QuestionId = questionId
            };

            await repo.AddAsync(answer);
            await repo.SaveChangesAsync();
        }

        public async Task<List<string>> GetAnswersByQuestionId(int id)
        {
            var answers = await repo.AllReadonly<QuestionAnswer>()
                .Where(a => a.QuestionId == id)//add active
                .Select(a => a.Value)
                .ToListAsync();

            return answers;
        }
    }
}
