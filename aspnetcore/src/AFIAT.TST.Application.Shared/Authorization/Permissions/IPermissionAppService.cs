using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AFIAT.TST.Authorization.Permissions.Dto;

namespace AFIAT.TST.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
