using AFIAT.TST.Editions.Dto;

namespace AFIAT.TST.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < TSTConsts.MinimumUpgradePaymentAmount;
        }
    }
}
