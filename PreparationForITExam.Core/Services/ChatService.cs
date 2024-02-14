using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Chat;
using PreparationForITExam.Infrastructure.Data.Common;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Services
{
    public class ChatService : IChatService
    {
        private readonly IRepository repo;

        public ChatService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<List<MessageModel>> GetAllMessagesOfUserBySenderId(string userId, string senderId)
        {
            var receivedMessages = await repo.AllReadonly<Message>()
                .Where(m => m.ReceiverId == userId)
                .Where(m => m.SenderId == senderId)
                .Select(m => new MessageModel
                {
                    MessageText = m.MessageText,
                    CreatedOn = m.CreatedOn,
                    Received = true
                })
                .ToListAsync();

            List<MessageModel> sentMessages = await repo.AllReadonly<Message>()
                .Where(m => m.ReceiverId == senderId)
                .Where(m => m.SenderId == userId)
                .Select(m => new MessageModel
                {
                    MessageText = m.MessageText,
                    CreatedOn = m.CreatedOn,
                    Received = false
                })
                .ToListAsync();

            List<MessageModel> model = new List<MessageModel>();

            model.AddRange(receivedMessages);
            model.AddRange(sentMessages);

            return model.OrderBy(model => model.CreatedOn).ToList();
        }
    }
}
