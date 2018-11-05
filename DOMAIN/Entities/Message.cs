using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public DateTime dateMessage { get; set; }
        public string content { get; set; }
        public virtual Chat Chat { get; set; }

    }
}
