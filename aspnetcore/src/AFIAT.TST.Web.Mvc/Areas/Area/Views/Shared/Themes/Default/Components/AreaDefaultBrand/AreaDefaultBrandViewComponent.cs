using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AFIAT.TST.Web.Areas.Area.Models.Layout;
using AFIAT.TST.Web.Session;
using AFIAT.TST.Web.Views;

namespace AFIAT.TST.Web.Areas.Area.Views.Shared.Themes.Default.Components.AreaDefaultBrand
{
    public class AreaDefaultBrandViewComponent : TSTViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AreaDefaultBrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
