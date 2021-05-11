using System.Threading.Tasks;
using Abp.Application.Services;
using AFIAT.TST.Configuration.Host.Dto;

namespace AFIAT.TST.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
