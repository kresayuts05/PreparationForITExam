using PreparationForITExam.Core.Models.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface ICommentService
    {
        Task Create(CommentFormViewModel model);
        Task<List<CommentViewModel>> GetPostComments(int postId, int page);
        Task<int> CommentCount(int podtId);
        Task<int> GetPostIdByCommentId(int id);
        Task Delete(int id);
        Task<int> CommentCountByUserId(string userId);
    }
}
