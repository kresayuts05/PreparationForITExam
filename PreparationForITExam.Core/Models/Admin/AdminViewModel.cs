using PreparationForITExam.Core.Models.Teacher;
using PreparationForITExam.Core.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.Admin
{
    public class AdminViewModel
    {
        public AdminViewModel()
        {
            Filtration = 0;
        }

        public int Filtration { get; set; }

        public List<UserModel> Users{ get; set; }

        public List<TeacherModel> Teachers { get; set; } = new List<TeacherModel>();
    }
}
