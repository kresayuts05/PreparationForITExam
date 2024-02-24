using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PreparationForITExam.Core.Models.Comment
{
    public class CommentViewModel
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public bool IsActive { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public string ProfilePicture { get; set; }

        public string UserRole { get; set; }

        public List<string> Images { get; set; }

        public string CreatedOn { get; set; }

        public int Likes { get; set; }
    }
}
