using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AFIAT.TST.Web.Areas.Area.Models.Layout;
using AFIAT.TST.Web.Views;

namespace AFIAT.TST.Web.Areas.Area.Views.Shared.Components.AreaRecentNotifications
{
    public class AreaRecentNotificationsViewComponent : TSTViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass)
        {
            var model = new RecentNotificationsViewModel
            {
                CssClass = cssClass
            };
            
            return Task.FromResult<IViewComponentResult>(View(model));
        }
    }
}
