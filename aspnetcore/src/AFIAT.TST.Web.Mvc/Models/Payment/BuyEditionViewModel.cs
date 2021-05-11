using System.Collections.Generic;
using AFIAT.TST.Editions;
using AFIAT.TST.Editions.Dto;
using AFIAT.TST.MultiTenancy.Payments;
using AFIAT.TST.MultiTenancy.Payments.Dto;

namespace AFIAT.TST.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
