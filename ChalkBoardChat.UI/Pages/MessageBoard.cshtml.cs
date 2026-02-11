using ChalkBoardChat.BLL.DTOs;
using ChalkBoardChat.BLL.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;


namespace ChalkBoardChat.UI.Pages
{
    public class MessageBoardModel : PageModel
    {

        private readonly IMessageService _messageService;
        private readonly UserManager<IdentityUser> _userManager;

        public MessageBoardModel(
            IMessageService messageService,
            UserManager<IdentityUser> userManager)
        {
            _messageService = messageService;
            _userManager = userManager;
        }

        public List<MessageDto> Messages { get; set; } = new();

        [BindProperty]
        public string NewMessage { get; set; }

        public async Task OnGetAsync()
        {
            Messages = await _messageService.GetAllMessagesAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (string.IsNullOrWhiteSpace(NewMessage))
                return Page();

            var userId = _userManager.GetUserId(User);

            await _messageService.AddMessageAsync(NewMessage, userId);

            return RedirectToPage();
        }
    }
}
