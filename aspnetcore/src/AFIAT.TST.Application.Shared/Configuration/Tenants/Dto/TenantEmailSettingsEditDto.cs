using Abp.Auditing;
using AFIAT.TST.Configuration.Dto;

namespace AFIAT.TST.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}