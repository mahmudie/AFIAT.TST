using System.Collections.Generic;
using Abp.Application.Services.Dto;
using AFIAT.TST.Configuration.Host.Dto;
using AFIAT.TST.Editions.Dto;

namespace AFIAT.TST.Web.Areas.Area.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }

        public List<string> EnabledSocialLoginSettings { get; set; } = new List<string>();
    }
}