using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface IQuestionAnswerService
    {
        Task Add(string value, int questionId);

        Task<List<string>> GetAnswersByQuestionId(int id);
    }
}
