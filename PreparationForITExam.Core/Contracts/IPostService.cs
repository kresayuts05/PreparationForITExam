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
        Task Create(PostFormViewModel model);
        Task<List<PostViewModel>> GetAllPosts(int page);
        Task<int> GetPostCount();
        Task<PostViewModel> GetPostDetails(int id, int page);
    }
}
