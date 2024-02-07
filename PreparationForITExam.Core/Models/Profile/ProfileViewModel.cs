using PreparationForITExam.Core.Models.Material;
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

        public string Name { get; set; }

        public string RoleName { get; set; }

        public int Materials { get; set; }

        public int Posts { get; set; }

        public int Questions { get; set; }

        public int Answers { get; set; }

        public string AboutMe { get; set; }

        public List<MaterialModel> MaterialsInLessons { get; set; }

        public Dictionary<int, string> PostsUrls { get; set; }

        public List<QuestionModel> AskedQuestions { get; set; }
    }
}
