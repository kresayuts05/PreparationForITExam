using Microsoft.SharePoint.Client;
using PreparationForITExam.Core.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.Question
{
    public class LessonCommentViewModel
    {
        public int Id { get; set; }

        public UserModel UserInfo { get; set; }

        public string Content { get; set; }

        public List<string> Likes { get; set; }

        public string? Url { get; set; }

        public string CreatedOn { get; set; }

        public string Title { get; set; }
    }
}
