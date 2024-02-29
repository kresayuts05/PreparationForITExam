using PreparationForITExam.Core.Models.Answer;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface IAnswerService
    {
        Task ZipUpload(byte[] file, string userId, int materialId);
        Task<List<AnswerModel>> GetAnswersByMaterialId(int materialId);
        Task<List<AnswerModel>> GetAnswersByUserId(string userId);
        Task Delete(int id);
     }
}
