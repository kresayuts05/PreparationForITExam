using Microsoft.SharePoint.Client;
using PreparationForITExam.Core.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.Question
{
    public class QuestionViewModel
    {
        public int Id { get; set; }

        public UserModel UserInfo { get; set; }

        public string Content { get; set; }

        public List<string> Likes { get; set; }

        public int Replys { get; set; }

        public string? Photo { get; set; }
    }
}
