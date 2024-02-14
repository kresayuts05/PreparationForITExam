using PreparationForITExam.Core.Models.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface IChatService
    {
        Task<List<MessageModel>> GetAllMessagesOfUserBySenderId(string userId, string senderId);
    }
}
