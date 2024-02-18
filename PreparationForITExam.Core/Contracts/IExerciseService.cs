using PreparationForITExam.Core.Models.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface IExerciseService
    {
        Task<ExerciseViewModel> GetExerciseById(int id);
        Task<List<ExerciseModel>> GetAllExercisesBySectionOfCurricularId(int sectionId);
        Task SetContentToExercise(string content, int id);
        Task<int> GetExerciseByMaterialId(int id);
    }
}
