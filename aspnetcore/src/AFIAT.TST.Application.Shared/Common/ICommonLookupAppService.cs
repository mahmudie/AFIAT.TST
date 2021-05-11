using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AFIAT.TST.Common.Dto;
using AFIAT.TST.Editions.Dto;

namespace AFIAT.TST.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}