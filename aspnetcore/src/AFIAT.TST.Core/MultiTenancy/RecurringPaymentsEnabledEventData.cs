using Abp.Events.Bus;

namespace AFIAT.TST.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}