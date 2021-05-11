using AFIAT.TST.MultiTenancy.Payments;

namespace AFIAT.TST.Web.Models.Payment
{
    public class CancelPaymentModel
    {
        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}