using System.Collections.Generic;
using Abp.Application.Services.Dto;
using AFIAT.TST.Configuration.Tenants.Dto;

namespace AFIAT.TST.Web.Areas.Area.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
        
        public List<string> EnabledSocialLoginSettings { get; set; } = new List<string>();
    }
}