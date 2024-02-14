using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.Chat
{
    public class MessageModel
    {
        public bool Received { get; set; }

        public string MessageText { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
