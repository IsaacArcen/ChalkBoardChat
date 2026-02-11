using ChalkBoardChat.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChalkBoardChat.DAL.Repositories
{
    internal interface IMessageRepository
    {
        Task AddAsyc(Message message);
        Task<List<Message>> GetAllAsync();
        Task<Message> GetByIdAsync(int id);
        Task SaveChangesAsync();
    }
}
