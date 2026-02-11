using ChalkBoardChat.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChalkBoardChat.DAL.Repositories
{
    public interface IMessageRepository
    {
        Task AddAsync(Message message);
        Task<List<Message>> GetAllAsync();
        Task<Message> GetByIdAsync(int id);
        Task SaveChangesAsync();
    }
}
