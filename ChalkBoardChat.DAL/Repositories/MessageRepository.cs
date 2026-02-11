using ChalkBoardChat.DAL.Contexts;
using ChalkBoardChat.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChalkBoardChat.DAL.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly AppDbContext _context;

        public MessageRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsyc(Message message)
        {
            await _context.Messages.AddAsync(message);
        }

        public async Task<List<Message>> GetAllAsync()
        {
            return await _context.Messages.ToListAsync();
        }

        public async Task<Message?> GetByIdAsync(int id)
        {
            return await _context.Messages.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
