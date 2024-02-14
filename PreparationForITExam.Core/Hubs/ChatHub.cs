using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Hubs
{
    [Authorize]
    public class ChatHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            Groups.AddToGroupAsync(Context.ConnectionId, Context.User.Identity.Name);
            return base.OnConnectedAsync();
        }


        public async Task SendMessage(Message message)
        {
            await Clients.All.SendAsync("receiveMessage", message);
        }


        //public async Task SendMessage(string user, string message)
        //{
        //    await Clients.All.SendAsync("ReceiveMessage", user, message);
        //}

        //public Task SendMessageToGroup(string sender, string receiver, string message)
        //{
        //    return Clients.Group(receiver).SendAsync("ReceiveMessage", sender, message);
        //}

        public Task SendMessageToUser(string sender, string receiver, string message)
        {
            //based on the receiver name to query the database and get the connection id



            return Clients.Client("connectionId").SendAsync("ReceiveMessage", sender, message);
        }
    }
}
