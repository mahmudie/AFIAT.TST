using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AFIAT.TST.Web.Areas.Area.Models.Layout;
using AFIAT.TST.Web.Session;
using AFIAT.TST.Web.Views;

namespace AFIAT.TST.Web.Areas.Area.Views.Shared.Themes.Theme2.Components.AreaTheme2Footer
{
    public class AreaTheme2FooterViewComponent : TSTViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AreaTheme2FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
