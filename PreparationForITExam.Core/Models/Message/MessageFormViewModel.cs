using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.UserConstraints;

namespace PreparationForITExam.Core.Models.Message
{
    public class MessageFormViewModel
    {
        public string SenderId { get; set; }

        public string SenderName { get; set; }

        public string ReceiverId { get; set; }

        public string ReceiverName { get; set; }
        
        public string MessageText { get; set; }
    }
}
