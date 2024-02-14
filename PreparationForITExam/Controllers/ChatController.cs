//using Microsoft.AspNetCore.Mvc;
//using PreparationForITExam.Core.Contracts;
//using PreparationForITExam.Core.Models.Chat;
//using PreparationForITExam.Core.Services;
//using PreparationForITExam.Extensions;

//namespace PreparationForITExam.Controllers
//{
//    public class ChatController : BaseController
//    {
//        private readonly IChatService chatService;

//        public ChatController(
//            IChatService _chatService)
//        {
//            chatService = _chatService;
//        }

//        public async Task<IActionResult> Index(string id)
//        {
//            var modelMessages = await chatService.GetAllMessagesOfUserBySenderId(this.User.Id(), id);

//            var model = new ChatViewModel
//            {
//                ReceiverId = this.User.Id(),
//                ReceiverName = "monuser@gmail.com",
//                SenderId = id,
//                SenderName = "student@gmail.com",

//                Messages = modelMessages
//            };
//            return View(model);
//        }

//        [HttpGet]
//        public async Task<IActionResult> GetUserParticularChatBySenderId(string id)
//        {
//            var modelMessages = await chatService.GetAllMessagesOfUserBySenderId(this.User.Id(), id);

//            var model = new ChatViewModel
//            {
//                ReceiverId = this.User.Id(),
//                ReceiverName = "monuser@gmail.com",
//                SenderId = id,
//                SenderName = "student@gmail.com",

//                Messages = modelMessages
//            };

//            RouteValueDictionary RouteInfo = new RouteValueDictionary();
//            RouteInfo.Add("model", model);

//            return RedirectToAction("Index", "Chat");
//        }

//    }
//}
