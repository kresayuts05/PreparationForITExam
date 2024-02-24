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
        Task<Image> UploadImage(IFormFile imageFile, string nameFolder, int postId);
        Task<List<ImageComment>> UploadImagesComment(List<IFormFile> imagesFiles, string nameFolder, int commentId);

        Task<string> UploadImage(IFormFile imageFile, string nameFolder, User user);

        Task<List<string>> GetPostImages(int id);
        Task<List<string>> GetCommentImages(int id);
    }
}
