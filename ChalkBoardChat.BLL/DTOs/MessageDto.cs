using System;
using System.Collections.Generic;
using System.Text;

namespace ChalkBoardChat.BLL.DTOs
{
    public class MessageDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }

    }
}
