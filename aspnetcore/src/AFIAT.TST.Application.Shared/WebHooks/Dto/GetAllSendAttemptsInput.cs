using AFIAT.TST.Dto;

namespace AFIAT.TST.WebHooks.Dto
{
    public class GetAllSendAttemptsInput : PagedInputDto
    {
        public string SubscriptionId { get; set; }
    }
}
