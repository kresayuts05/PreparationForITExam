using PreparationForITExam.Core.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface IPostService
    {
        Task Create(PostFormViewModel model, bool isItQuestion);
        Task<List<PostViewModel>> GetAllPosts(int page);
        Task<List<PostViewModel>> GetOnlyPosts(int page);
        Task<List<PostViewModel>> GetOnlyQuestions(int page);
        Task<PostViewModel> GetPostDetails(int id, int page);
        Task<PostFormViewModel> GetPostInfo(int id);
        Task<int> GetPostCount();
        Task<int> GetOnlyPostsCount();
        Task<int> GetOnlyQuestionsCount();
        Task Edit(PostFormViewModel model);

        Task<List<PostModel>> GetAllPostsUrlsByUserId(string userId);
        Task<List<PostModel>> GetAllQuestionsUrlsByUserId(string userId);
    }
}
