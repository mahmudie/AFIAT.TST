using System.Linq;
using System.Threading.Tasks;
using Abp.Localization;
using Microsoft.AspNetCore.Mvc;
using AFIAT.TST.Web.Areas.Area.Models.Layout;
using AFIAT.TST.Web.Views;

namespace AFIAT.TST.Web.Areas.Area.Views.Shared.Components.AreaLanguageSwitch
{
    public class AreaLanguageSwitchViewComponent : TSTViewComponent
    {
        private readonly ILanguageManager _languageManager;

        public AreaLanguageSwitchViewComponent(ILanguageManager languageManager)
        {
            _languageManager = languageManager;
        }

        public Task<IViewComponentResult> InvokeAsync(string cssClass)
        {
            var model = new LanguageSwitchViewModel
            {
                Languages = _languageManager.GetActiveLanguages().ToList(),
                CurrentLanguage = _languageManager.CurrentLanguage,
                CssClass = cssClass
            };
            
            return Task.FromResult<IViewComponentResult>(View(model));
        }
    }
}
