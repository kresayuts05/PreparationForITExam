using Microsoft.AspNetCore.Mvc;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.Message;
using PreparationForITExam.Core.Services;

namespace PreparationForITExam.Controllers
{
    public class MessageController : BaseController
    {
        private readonly IMessageService messageService;

        public MessageController(
            IMessageService _messageService)
        {
            messageService = _messageService;
        }

        public async Task<IActionResult> Create(MessageFormViewModel model)
        {
            await messageService.CreateMessage(model);
            return Ok();
        }
    }
}
