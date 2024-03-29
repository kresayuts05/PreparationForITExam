﻿using Microsoft.SharePoint.Portal.WebControls;
using PreparationForITExam.Core.Models.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface IUserService
    {
        Task<bool> UserByEmailExists(string email);

        Task<string> UserNameById(string id);

        Task<ProfileViewModel> GetUserInfo(string id);
    }
}
