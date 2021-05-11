using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AFIAT.TST.Chat.Dto;

namespace AFIAT.TST.Chat
{
    public interface IChatAppService : IApplicationService
    {
        GetUserChatFriendsWithSettingsOutput GetUserChatFriendsWithSettings();

        Task<ListResultDto<ChatMessageDto>> GetUserChatMessages(GetUserChatMessagesInput input);

        Task MarkAllUnreadMessagesOfUserAsRead(MarkAllUnreadMessagesOfUserAsReadInput input);
    }
}
