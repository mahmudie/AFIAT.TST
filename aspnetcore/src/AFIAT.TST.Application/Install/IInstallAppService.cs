using System.Threading.Tasks;
using Abp.Application.Services;
using AFIAT.TST.Install.Dto;

namespace AFIAT.TST.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}