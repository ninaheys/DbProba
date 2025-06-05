using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzepNev.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }

        public Message()
        {
        }

        public Message(string userName, string content)
        {
            UserName = userName;
            Content = content;
        }
    }
}
