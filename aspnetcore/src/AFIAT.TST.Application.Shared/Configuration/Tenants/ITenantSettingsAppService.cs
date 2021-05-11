using System.Threading.Tasks;
using Abp.Application.Services;
using AFIAT.TST.Configuration.Tenants.Dto;

namespace AFIAT.TST.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
