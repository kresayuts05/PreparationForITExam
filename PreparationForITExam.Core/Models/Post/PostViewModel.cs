using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PreparationForITExam.Core.Models.Comment;

namespace PreparationForITExam.Core.Models.Post
{
    public class PostViewModel
    {

        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string ShortDescription { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string PostedOn { get; set; }

        public bool IsActive { get; set; }

        public string UsefulUrl { get; set; }

        public int Likes { get; set; }

        public bool IsItQuestion { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public string UserProfilePicture { get; set; }

        public int CommentsCount { get; set; }
        public List<CommentViewModel> Comments { get; set; }
        public List<string> Images { get; set; }

        public CommentFormViewModel CommentModel { get; set; }
    }
}
