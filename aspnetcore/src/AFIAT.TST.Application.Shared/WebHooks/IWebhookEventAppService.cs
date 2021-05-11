using System.Threading.Tasks;
using Abp.Webhooks;

namespace AFIAT.TST.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
