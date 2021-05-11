using System.Threading.Tasks;
using AFIAT.TST.Authorization.Users;

namespace AFIAT.TST.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
