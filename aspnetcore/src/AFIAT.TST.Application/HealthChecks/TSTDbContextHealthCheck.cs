using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using AFIAT.TST.EntityFrameworkCore;

namespace AFIAT.TST.HealthChecks
{
    public class TSTDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public TSTDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("TSTDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("TSTDbContext could not connect to database"));
        }
    }
}
