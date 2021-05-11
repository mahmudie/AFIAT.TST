using AFIAT.TST.Editions;
using AFIAT.TST.Editions.Dto;
using AFIAT.TST.MultiTenancy.Payments;
using AFIAT.TST.Security;
using AFIAT.TST.MultiTenancy.Payments.Dto;

namespace AFIAT.TST.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
