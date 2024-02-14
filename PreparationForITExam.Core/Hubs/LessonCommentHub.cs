using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Hubs
{
    public class LessonCommentHub:Hub
    {
        public async Task SendMessage(MessageProcessingHandler message)
        {
            await Clients.All.SendAsync("receiveMessage");
        }
    }
}
