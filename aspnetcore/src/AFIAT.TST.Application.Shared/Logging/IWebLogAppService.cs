using Abp.Application.Services;
using AFIAT.TST.Dto;
using AFIAT.TST.Logging.Dto;

namespace AFIAT.TST.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
