using System.Threading.Tasks;
using Abp.Application.Services;
using AFIAT.TST.Editions.Dto;
using AFIAT.TST.MultiTenancy.Dto;

namespace AFIAT.TST.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}