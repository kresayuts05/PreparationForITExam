using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
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
        Task ZipUpload(IFormFile file, string userId, int lessonId);
        Task ZipUpload(byte[] file, string userId, int lessonId);
    }
}
