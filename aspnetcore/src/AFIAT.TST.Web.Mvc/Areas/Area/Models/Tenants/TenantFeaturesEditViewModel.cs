using Abp.AutoMapper;
using AFIAT.TST.MultiTenancy;
using AFIAT.TST.MultiTenancy.Dto;
using AFIAT.TST.Web.Areas.Area.Models.Common;

namespace AFIAT.TST.Web.Areas.Area.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}