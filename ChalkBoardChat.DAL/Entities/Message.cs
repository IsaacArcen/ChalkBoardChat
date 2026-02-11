using System;
using System.Collections.Generic;
using System.Text;

namespace ChalkBoardChat.DAL.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
    }
}
