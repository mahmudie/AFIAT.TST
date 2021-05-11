using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AFIAT.TST.Authorization.Users.Dto;

namespace AFIAT.TST.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
