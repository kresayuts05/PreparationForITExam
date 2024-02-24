
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.SharePoint.Portal.WebControls.WSRPWebService;
using Microsoft.SharePoint.Publishing.Fields;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Infrastructure.Data.Common;
using PreparationForITExam.Infrastructure.Data.Entities;
using Syncfusion.Presentation;
using Syncfusion.PresentationRenderer;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Services
{
    public class ImageService : IImageService
    {
        private readonly Cloudinary cloudinary;
        private readonly IRepository repo;

        public ImageService(
            Cloudinary cloudinary,
            IRepository _repo)
        {
            this.cloudinary = cloudinary;
            repo = _repo;
        }

        public async Task<List<string>> GetPostImages(int id)
        {
            var images = await repo.AllReadonly<Image>()
                .Where(i => i.PostId == id && i.IsActive)
                .Select(i => i.UrlPath)
                .ToListAsync();

            return images;
        }
        public async Task<List<string>> GetCommentImages(int id)
        {
            var images = await repo.AllReadonly<ImageComment>()
                .Where(i => i.CommentId == id && i.IsActive)
                .Select(i => i.UrlPath)
                .ToListAsync();

            return images;
        }

        public async Task<string> UploadImage(IFormFile imageFile, string nameFolder, User user)
        {
            using var stream = imageFile.OpenReadStream();

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(user.Id, stream),
                Folder = nameFolder,
            };

            var result = await this.cloudinary.UploadAsync(uploadParams);

            if (result.Error != null)
            {
                throw new InvalidOperationException(result.Error.Message);
            }

            user.ProfilePictureUrl = result.Url.ToString();

            this.repo.Update(user);
            await this.repo.SaveChangesAsync();

            return user.ProfilePictureUrl;
        }

        public async Task<Image> UploadImage(IFormFile imageFile, string nameFolder, int postId)
        {
            using var stream = imageFile.OpenReadStream();
            var image = new Image();

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(image.Id.ToString(), stream),
                Folder = nameFolder,
            };

            var result = await this.cloudinary.UploadAsync(uploadParams);

            if (result.Error != null)
            {
                throw new InvalidOperationException(result.Error.Message);
            }

            image.UrlPath = result.Url.ToString();
            image.PostId = postId;
            image.IsActive = true;

            await this.repo.AddAsync(image);
            await this.repo.SaveChangesAsync();

            return image;
        }

        public async Task<List<ImageComment>> UploadImagesComment(List<IFormFile> imagesFiles, string nameFolder, int commentId)
        {
            List<ImageComment> images = new List<ImageComment>();

            foreach (var image in imagesFiles)
            {
                using var stream = image.OpenReadStream();
                var imageInfo = new ImageComment();

                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(imageInfo.Id.ToString(), stream),
                    Folder = nameFolder,
                };

                var result = await this.cloudinary.UploadAsync(uploadParams);

                if (result.Error != null)
                {
                    throw new InvalidOperationException(result.Error.Message);
                }

                imageInfo.UrlPath = result.Url.ToString();
                imageInfo.CommentId = commentId;
                imageInfo.IsActive = true;

                images.Add(imageInfo);
            }
          
            await this.repo.AddRangeAsync(images);
            await this.repo.SaveChangesAsync();

            return images;
        }
    }
}
