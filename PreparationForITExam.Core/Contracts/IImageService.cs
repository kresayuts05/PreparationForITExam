using Microsoft.AspNetCore.Http;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface IImageService
    {
       // Task<Image> UploadImage(IFormFile imageFile, string nameFolder, int postId);

        Task<string> UploadImage(IFormFile imageFile, string nameFolder, User user);
    }
}
