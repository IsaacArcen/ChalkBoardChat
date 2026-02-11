using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ChalkBoardChat.BLL.Services
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _repository;

        public MessageService(IMessageRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<MessageDto>> GetAllMessagesAsync()
        {
            var messages = await _repository.GetAllMessagesAsync();
            
            
            var sorted = messages
                .OrderByDescending(m => m.Date)
                .Select(m => new MessageDto
                {
                    Id = m.Id,
                    Content = m.Content,
                    Date = m.Date,
                    UserId = m.UserId
                })
                .ToList();

            return sorted;
        }

        public async Task AddMessageAsync(string content, string userId)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentException("Message content cannot be empty.");
            }

            var message = new Message
            {
                Content = content,
                Date = DateTime.UtcNow,
                UserId = userId
            };

            await _repository.AddAsync(message);
            await _repository.SaveChangesAsync();
        }
    }
}
