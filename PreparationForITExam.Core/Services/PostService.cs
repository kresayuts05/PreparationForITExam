﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Server.Search.Extended.Administration.Common;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Comment;
using PreparationForITExam.Core.Models.Post;
using PreparationForITExam.Infrastructure.Data.Common;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Services
{
    public class PostService : IPostService
    {

        private readonly IRepository repo;
        private readonly IImageService imageService;
        private readonly ICommentService commentService;

        public PostService(IRepository _repo, IImageService _imageService,ICommentService _commentService)
        {
            repo = _repo;
            imageService = _imageService;
            commentService = _commentService;
        }

        public async Task Create(PostFormViewModel model)
        {
            Post post = new Post
            {
                Title = model.Title,
                Description = model.Description,
                ShortDescription = model.ShortDescription,
                UsefulUrl = model.UsefulUrl,
                UserId = model.UserId
            };

            await repo.AddAsync(post);
            await repo.SaveChangesAsync();

            if (model.Images.Any())
            {
                foreach (var imageInfo in model.Images)
                {
                    var image = await this.imageService.UploadImage(imageInfo, "images", post.Id);
                    post.Images.Add(image);
                }
            }

            await repo.SaveChangesAsync();
        }

        public async Task<List<PostViewModel>> GetAllPosts(int page)
        {
            var model = await repo.AllReadonly<Post>()
                 .Where(p => p.IsActive)
                 .OrderByDescending(p => p.Id)
                 .Skip(9 * ((int)(page == 0 ? 1 : page) - 1))
                 .Take(9)
                 .Select(p => new PostViewModel
                 {
                     Id = p.Id,
                     Title = p.Title,
                     Description = p.Description,
                     ShortDescription = p.ShortDescription,
                     UserId = p.UserId,
                     UserName = p.User.FirstName + " " + p.User.LastName,
                     UserProfilePicture = p.User.ProfilePictureUrl,
                     UsefulUrl = p.UsefulUrl,
                     PostedOn = p.PostedOn.ToString("yyyy-M-d"),
                     CommentsCount = p.Comments.Where(c=> c.IsActive).ToList().Count
                  
                 })
                 .ToListAsync();

            for (int i = 0; i < model.Count; i++)
            {
                model[i].Images = await imageService.GetPostImages(model[i].Id);
            }

            return model;
        }

        public async Task<int> GetPostCount()
        {
            var posts = await repo.AllReadonly<Post>()
                .Where(p => p.IsActive)
                .ToListAsync();

            return posts.Count;
        }

        public async Task<PostViewModel> GetPostDetails(int id, int page)
        {
            var model = await repo.AllReadonly<Post>()
                 .Where(p => p.IsActive && p.Id == id)
                 .Select(p => new PostViewModel
                 {
                     Id = p.Id,
                     Title = p.Title,
                     Description = p.Description,
                     ShortDescription = p.ShortDescription,
                     UserId = p.UserId,
                     UserName = p.User.FirstName + " " + p.User.LastName,
                     UserProfilePicture = p.User.ProfilePictureUrl,
                     UsefulUrl = p.UsefulUrl,
                     PostedOn = p.PostedOn.ToString("yyyy-M-d"),
                 })
                 .FirstOrDefaultAsync();

            model.Images = await imageService.GetPostImages(id);
            model.Comments = await commentService.GetPostComments(id, page);

            return model;
        }
    }
}
