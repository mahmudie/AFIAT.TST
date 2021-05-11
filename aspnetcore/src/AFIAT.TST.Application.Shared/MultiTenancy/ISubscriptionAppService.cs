using System.Threading.Tasks;
using Abp.Application.Services;

namespace AFIAT.TST.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
