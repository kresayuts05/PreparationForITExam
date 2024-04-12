using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.User
{
    //This model is used for displaying user information in the views.
    //It transfers data from services to the controllers
    public class UserModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string ProfilePictureUrl { get; set; }

        public string Role { get; set; }

        public string City { get; set; }

        public string SchoolName { get; set; }

        public int UserInRoleId { get; set; }

    }
}
