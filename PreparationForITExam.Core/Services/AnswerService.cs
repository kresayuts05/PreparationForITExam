using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Answer;
using PreparationForITExam.Infrastructure.Data.Common;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Services
{
    public class AnswerService : IAnswerService
    {
        private readonly IRepository repo;
        private readonly Cloudinary cloudinary;

        public AnswerService(
            IRepository _repo,
            Cloudinary _cloudinary)
        {
            cloudinary = _cloudinary;
            repo = _repo;
        }

        public async Task ZipUpload(byte[] file, string userId, int materialId)
        {
            string name = await repo.AllReadonly<ExerciseMaterial>()
                .Where(l => l.Id == materialId)
                .Where(l => l.IsActive == true)
                .Select(l => l.Name)
                .FirstOrDefaultAsync();

            using (Stream input = new MemoryStream(file))
            {
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription("raw", input),
                    Folder = "zips",
                };

                var result = await this.cloudinary.UploadAsync("raw", null, new FileDescription($"{name}.zip", input));

                if (result.Error != null)
                {
                    throw new InvalidOperationException(result.Error.Message);
                }

                var url = result.Url.ToString().Replace("http", "https");

                var answer = new Answer
                {
                    Name = $"{userId} zip",
                    UrlPath = url,
                    FileFormat = ".zip",
                    ExerciseMaterialId = materialId,
                    UserId = userId
                };
                await repo.AddAsync<Answer>(answer);

                await repo.SaveChangesAsync();
            }
        }

        public async Task<List<AnswerModel>> GetAnswersByMaterialId(int materialId)
        {
            var model = await repo.AllReadonly<Answer>()
                .Where(m => m.ExerciseMaterialId == materialId)
                .Where(m => m.IsActive == true)
                .Select(m => new AnswerModel
                {
                    Id = m.Id,
                    Name = m.Name,
                    UrlPath = m.UrlPath,
                    FileFormat = m.FileFormat,
                    UserName = m.User.FirstName + " " + m.User.LastName,
                    UserId = m.UserId,
                    ExerciseMaterialId = m.ExerciseMaterialId
                })
                .ToListAsync();

            return model;
        }

        public async Task<List<AnswerModel>> GetAnswersByUserId(string  userID)
        {
            var model = await repo.AllReadonly<Answer>()
                .Where(m => m.UserId == userID)
                .Where(m => m.IsActive == true)
                .Select(m => new AnswerModel
                {
                    Id = m.Id,
                    Name = m.Name,
                    UrlPath = m.UrlPath,
                    FileFormat = m.FileFormat,
                    UserName = m.User.FirstName + " " + m.User.LastName,
                    UserId = m.UserId,
                    ExerciseMaterialId = m.ExerciseMaterialId
                })
                .ToListAsync();

            return model;
        }
    }
}
