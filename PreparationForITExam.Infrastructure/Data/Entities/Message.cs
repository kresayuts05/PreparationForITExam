using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.MessageConstraints;

namespace PreparationForITExam.Infrastructure.Data.Entities
{

    public class Message
    {
        public Message()
        {
            CreatedOn= DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        public string SenderId { get; set; }

        public string SenderName { get; set; }

        public string ReceiverId { get; set; }

        public string ReceiverName { get; set; }
        
        [MaxLength(MessageTextMaxLength)]
        public string MessageText { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
