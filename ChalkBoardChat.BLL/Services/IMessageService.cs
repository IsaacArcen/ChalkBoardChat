using ChalkBoardChat.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChalkBoardChat.BLL.Services
{
    public interface IMessageService
    {
       Task<List<MessageDto>> GetAllMessagesAsync();
        Task AddMessageAsync(string content, string userId);
    }
}
