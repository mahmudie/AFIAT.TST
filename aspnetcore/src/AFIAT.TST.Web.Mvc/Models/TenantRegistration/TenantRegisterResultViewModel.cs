using Abp.AutoMapper;
using AFIAT.TST.MultiTenancy.Dto;

namespace AFIAT.TST.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}