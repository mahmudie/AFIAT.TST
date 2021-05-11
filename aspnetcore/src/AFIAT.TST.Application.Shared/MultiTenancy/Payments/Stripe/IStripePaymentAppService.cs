using System.Threading.Tasks;
using Abp.Application.Services;
using AFIAT.TST.MultiTenancy.Payments.Dto;
using AFIAT.TST.MultiTenancy.Payments.Stripe.Dto;

namespace AFIAT.TST.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}