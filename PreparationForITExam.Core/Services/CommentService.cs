using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Server.Search.Administration;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Comment;
using PreparationForITExam.Infrastructure.Data.Common;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Services
{
    public class CommentService : ICommentService
    {
        private readonly IRepository repo;
        private readonly IImageService imageService;

        public CommentService(
            IRepository _repo,
            IImageService _imageService)
        {
            repo = _repo;
            imageService = _imageService;
        }

        public async Task<int> CommentCount(int postId)
        {
            var list = await repo.AllReadonly<Comment>()
                .Where(c => c.IsActive == true && c.PostId == postId)
                .Select(c => c.Id)
                .ToListAsync();

            return list.Count;
        }

        public async Task Create(CommentFormViewModel model)
        {
            Comment comment = new Comment()
            {
                Content = model.Content,
                UserId = model.UserId,
                PostId = model.PostId
            };

            await repo.AddAsync(comment);
            await repo.SaveChangesAsync();

            if (model.Images != null)
            {
                comment.Images = await imageService.UploadImagesComment(model.Images, "comments", comment.Id);
                await repo.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            var comment = await repo.GetByIdAsync<Comment>(id);

            comment.IsActive = false;
            await repo.SaveChangesAsync();
        }

        public async Task<List<CommentViewModel>> GetPostComments(int postId, int page)
        {
            var model = await repo.AllReadonly<Comment>()
                .Where(c => c.IsActive == true && c.PostId == postId)
                .OrderByDescending(p => p.Id)
                 .Skip(9 * ((int)(page == 0 ? 1 : page) - 1))
                 .Take(9)
                .Select(c => new CommentViewModel
                {
                    Id = c.Id,
                    Content = c.Content,
                    UserId = c.UserId,
                    UserName = c.User.FirstName + " " + c.User.LastName,
                    ProfilePicture = c.User.ProfilePictureUrl,
                    UserRole = c.User.RoleName,
                    CreatedOn = c.CreatedOn.ToString("yyyy-M-d")
                })
                .ToListAsync();

            foreach (var c in model)
            {
                c.Images = await imageService.GetCommentImages(c.Id);
            }

            return model;
        }

        public async Task<int> GetPostIdByCommentId(int id)
        {
            var comment = await repo.GetByIdAsync<Comment>(id);

            return comment.PostId;
        }
    }
}
