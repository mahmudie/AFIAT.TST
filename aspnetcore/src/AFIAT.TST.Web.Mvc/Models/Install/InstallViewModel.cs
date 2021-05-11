using System.Collections.Generic;
using Abp.Localization;
using AFIAT.TST.Install.Dto;

namespace AFIAT.TST.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
