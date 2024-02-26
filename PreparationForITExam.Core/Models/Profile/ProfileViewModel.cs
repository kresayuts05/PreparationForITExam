using PreparationForITExam.Core.Models.Answer;
using PreparationForITExam.Core.Models.Material;
using PreparationForITExam.Core.Models.Post;
using PreparationForITExam.Core.Models.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.Profile
{
    public class ProfileViewModel
    {
        public string Id { get; set; }

        public string ProfilePicture { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AboutMe { get; set; }
        public string RoleName { get; set; }
        public string City { get; set; }
       // public string  School { get; set; }


        public int Materials { get; set; }

        public int Posts { get; set; }

        public int Questions { get; set; }

        public int Comments { get; set; }

        public List<MaterialModel> MaterialsInLessons { get; set; }

        public List<MaterialModel> MaterialsInExercise { get; set; }
        public List<AnswerModel> Answers { get; set; }

        // id title
        public List<PostModel> PostsUrls { get; set; }
        public List<PostModel> QuestionsUrls { get; set; }
    }
}
