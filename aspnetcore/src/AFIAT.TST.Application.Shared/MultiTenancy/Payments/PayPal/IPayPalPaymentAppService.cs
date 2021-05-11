using System.Threading.Tasks;
using Abp.Application.Services;
using AFIAT.TST.MultiTenancy.Payments.PayPal.Dto;

namespace AFIAT.TST.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
