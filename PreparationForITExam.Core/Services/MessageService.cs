using CloudinaryDotNet;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Message;
using PreparationForITExam.Infrastructure.Data.Common;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Services
{
    public class MessageService : IMessageService
    {
        private readonly IRepository repo;

        public MessageService(
            IRepository _repo)
        {
            repo = _repo;
        }

        public async Task CreateMessage(MessageFormViewModel model)
        {
            Message message = new Message
            {
                SenderId = model.SenderId,
                SenderName = model.SenderName,
                ReceiverId = model.ReceiverId,
                ReceiverName = model.ReceiverName,
                MessageText = model.MessageText
            };

            await repo.AddAsync(message);
            await repo.SaveChangesAsync();
        }
    }
}
