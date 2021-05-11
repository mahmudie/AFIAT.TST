using System.Collections.Generic;
using AFIAT.TST.Editions.Dto;
using AFIAT.TST.MultiTenancy.Payments;

namespace AFIAT.TST.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}