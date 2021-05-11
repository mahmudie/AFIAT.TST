using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AFIAT.TST.Caching.Dto;

namespace AFIAT.TST.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}
