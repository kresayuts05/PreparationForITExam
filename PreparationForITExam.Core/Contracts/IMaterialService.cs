using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using PreparationForITExam.Core.Models.Material;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface IMaterialService
    {
        Task ConvertPresentationToJpeg(IFormFile file, string userId, int lessonId);
        Task ConvertPresentationToPdf(IFormFile file, string userId, int lessonId);
        Task ConvertWordDocumentToPdf(IFormFile file, string userId, int lessonId, bool IsForExercise);
        Task ConvertWordDocumentsToPdf(List<IFormFile> file, string userId, int lessonId, bool IsForExercise);
        Task ZipUpload(byte[] file, string userId, int lessonId, bool IsForExercise);
        Task ZipUpload(byte[] file, string userId, int lessonId, bool IsForExercise, bool IsStudentMaterial);
        Task ZipUploadAnswer(byte[] file, string userId, int exerciseMaterialId);
        Task<string> GetPresentationUrlByLessonId(int lessonId);
        Task<string> GetDocumentUrlByExerciseId(int exerciseId);
        Task<List<MaterialModel>> GetAllMaterialsForLessonById(int lessonId);
        Task<List<MaterialModel>> GetAllMaterialsForExerciseById(int exerciseId);
        Task<List<MaterialModel>> GetAllMaterialsForExerciseByIdByStudent(int exerciseId);
        Task DeleteMaterial(int id, bool IsForExercise);
        Task<List<MaterialModel>> GetAllMaterialsForExerciseByUserId(string userId);
        Task<List<MaterialModel>> GetAllMaterialsForLessonByUserId(string userId);
        Task<string> GetUserIdByMaterialId(int id, bool isForExercise);
        Task<int> GetExerciseIdByMaterialId(int id);

        //Task ZipUpload(IFormFile file, string userId, int lessonId);
    }
}
