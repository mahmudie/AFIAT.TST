using Abp.AutoMapper;
using AFIAT.TST.Sessions.Dto;

namespace AFIAT.TST.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}