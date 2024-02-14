using PreparationForITExam.Core.Models.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface IMessageService
    {
        Task CreateMessage(MessageFormViewModel model);
    }
}
