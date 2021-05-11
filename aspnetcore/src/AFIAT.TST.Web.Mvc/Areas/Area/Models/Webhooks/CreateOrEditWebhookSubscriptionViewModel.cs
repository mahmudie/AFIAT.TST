using Abp.Application.Services.Dto;
using Abp.Webhooks;
using AFIAT.TST.WebHooks.Dto;

namespace AFIAT.TST.Web.Areas.Area.Models.Webhooks
{
    public class CreateOrEditWebhookSubscriptionViewModel
    {
        public WebhookSubscription WebhookSubscription { get; set; }

        public ListResultDto<GetAllAvailableWebhooksOutput> AvailableWebhookEvents { get; set; }
    }
}
