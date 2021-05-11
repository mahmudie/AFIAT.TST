using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AFIAT.TST.Web.Areas.Area.Models.Layout;
using AFIAT.TST.Web.Views;

namespace AFIAT.TST.Web.Areas.Area.Views.Shared.Components.
    AreaQuickThemeSelect
{
    public class AreaQuickThemeSelectViewComponent : TSTViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass)
        {
            return Task.FromResult<IViewComponentResult>(View(new QuickThemeSelectionViewModel
            {
                CssClass = cssClass
            }));
        }
    }
}
