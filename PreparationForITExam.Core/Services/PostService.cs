using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Server.Search.Extended.Administration.Common;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Exception;
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
    //This class contains all buisness logic connected with posts and questions. 
    public class PostService : IPostService
    {

        private readonly IRepository repo;
        private readonly IImageService imageService;
        private readonly ICommentService commentService;

        public PostService(IRepository _repo, IImageService _imageService, ICommentService _commentService)
        {
            repo = _repo;
            imageService = _imageService;
            commentService = _commentService;
        }

        //This method creates posts and questions. Its parameter isItQuestion determines the type:post or question
        public async Task Create(PostFormViewModel model, bool isItQuestion)
        {
            Post post = new Post
            {
                Title = model.Title,
                Description = model.Description,
                ShortDescription = model.ShortDescription,
                UsefulUrl = model.UsefulUrl,
                UserId = model.UserId,
                IsItQuestion = isItQuestion
            };

            await repo.AddAsync(post);
            await repo.SaveChangesAsync();

            if (model.Images != null)
            {
                foreach (var imageInfo in model.Images)
                {
                    var image = await this.imageService.UploadImage(imageInfo, "images", post.Id);
                    post.Images.Add(image);
                }
                await repo.SaveChangesAsync();
            }

        }

        //This method returns collection of PostViewModel. It is used for displaying all posts and questions in the forum
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

                 })
                 .ToListAsync();

            for (int i = 0; i < model.Count; i++)
            {
                if (model[i].Images != null)
                {
                    model[i].Images = await imageService.GetPostImages(model[i].Id);
                    model[i].CommentsCount = await commentService.CommentCount(model[i].Id);
                }
            }

            return model;
        }

        //This method returns only posts. It is filtration
        public async Task<List<PostViewModel>> GetOnlyPosts(int page)
        {
            var model = await repo.AllReadonly<Post>()
                 .Where(p => p.IsActive && p.IsItQuestion == false)
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
                     CommentsCount = p.Comments.Where(c => c.IsActive).ToList().Count

                 })
                 .ToListAsync();

            for (int i = 0; i < model.Count; i++)
            {
                if (model[i].Images != null)
                {
                    model[i].Images = await imageService.GetPostImages(model[i].Id);
                }
            }

            return model;
        }

        //This method returns only questions. It is filtration
        public async Task<List<PostViewModel>> GetOnlyQuestions(int page)
        {
            var model = await repo.AllReadonly<Post>()
                 .Where(p => p.IsActive && p.IsItQuestion == true)
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
                     CommentsCount = p.Comments.Where(c => c.IsActive).ToList().Count

                 })
                 .ToListAsync();

            for (int i = 0; i < model.Count; i++)
            {
                model[i].Images = await imageService.GetPostImages(model[i].Id);
            }

            return model;
        }

        //This method returns posts count. It is used for pagination
        public async Task<int> GetPostCount()
        {
            var posts = await repo.AllReadonly<Post>()
                .Where(p => p.IsActive)
                .ToListAsync();

            return posts.Count;
        }

        //This method returns only posts count. It is used for pagination
        public async Task<int> GetOnlyPostsCount()
        {
            var posts = await repo.AllReadonly<Post>()
                .Where(p => p.IsActive && p.IsItQuestion == false)
                .ToListAsync();

            return posts.Count;
        }

        //This method returns only question count. It is used for pagination
        public async Task<int> GetOnlyQuestionsCount()
        {
            var posts = await repo.AllReadonly<Post>()
                .Where(p => p.IsActive && p.IsItQuestion == true)
                .ToListAsync();

            return posts.Count;
        }

        //This method returns the details of certain post.
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
                     UserRole = p.User.RoleName,
                     PostedOn = p.PostedOn.ToString("yyyy-M-d"),
                 })
                 .FirstOrDefaultAsync();

            model.Images = await imageService.GetPostImages(id);
            model.Comments = await commentService.GetPostComments(id, page);

            return model;
        }

        //This method returns the details of certain post.
        public async Task<PostFormViewModel> GetPostInfo(int id)
        {
            var model = await repo.AllReadonly<Post>()
                 .Where(p => p.IsActive && p.Id == id)
                 .Select(p => new PostFormViewModel
                 {
                     Id = p.Id,
                     Title = p.Title,
                     Description = p.Description,
                     ShortDescription = p.ShortDescription,
                     UserId = p.UserId,
                     UsefulUrl = p.UsefulUrl,
                     IsItQuestion = p.IsItQuestion
                 })
                 .FirstOrDefaultAsync();

            //model.Images = await imageService.GetPostImages(id);

            return model;
        }

        //This method edits the information in a post or question
        public async Task Edit(PostFormViewModel model)
        {
            var post = await repo.GetByIdAsync<Post>(model.Id);

            post.Title = model.Title;
            post.Description = model.Description;
            post.ShortDescription = model.ShortDescription;
            post.UsefulUrl = model.UsefulUrl;
            post.UserId = model.UserId;
            post.IsItQuestion = model.IsItQuestion;

            await repo.SaveChangesAsync();

        }

        //This method returns a collection of PostModel. It is used in the profile page to be accessible
        //to is creator and other users
        public async Task<List<PostModel>> GetAllPostsUrlsByUserId(string userId)
        {
            var model = await repo.AllReadonly<Post>()
                .Where(p => p.UserId == userId)
                .Where(p => p.IsActive == true && p.IsItQuestion == false)
                .Select(p => new PostModel
                {
                    Id = p.Id,
                    Title = p.Title,
                })
                .ToListAsync();

            return model;
        }

        //This method returns a collection of PostModel. It is used in the profile page to be accessible
        //to is creator and other users
        public async Task<List<PostModel>> GetAllQuestionsUrlsByUserId(string userId)
        {
            var model = await repo.AllReadonly<Post>()
                .Where(p => p.UserId == userId)
                .Where(p => p.IsActive == true && p.IsItQuestion == true)
                .Select(p => new PostModel
                {
                    Id = p.Id,
                    Title = p.Title,
                })
                .ToListAsync();

            return model;
        }

        //This method "deletes" post. It changes Is Active to false and it is no longer accessible
        public async Task Delete(int id)
        {
            var post = await repo.GetByIdAsync<Post>(id);

            if (post == null)
            {
                throw new NullReferenceException(GlobalExceptions.PostDoesNotExistExceptionMessage);
            }

            post.IsActive = false;
            await repo.SaveChangesAsync();
        }
    }
}
