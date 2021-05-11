using Abp.AutoMapper;
using AFIAT.TST.MultiTenancy.Dto;

namespace AFIAT.TST.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
