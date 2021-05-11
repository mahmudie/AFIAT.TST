using System.Threading.Tasks;
using Abp.Application.Services;
using AFIAT.TST.Sessions.Dto;

namespace AFIAT.TST.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
