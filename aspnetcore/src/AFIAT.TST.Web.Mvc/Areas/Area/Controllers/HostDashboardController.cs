using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using AFIAT.TST.Authorization;
using AFIAT.TST.DashboardCustomization;
using System.Threading.Tasks;
using AFIAT.TST.Web.Areas.Area.Startup;

namespace AFIAT.TST.Web.Areas.Area.Controllers
{
    [Area("Area")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Host_Dashboard)]
    public class HostDashboardController : CustomizableDashboardControllerBase
    {
        public HostDashboardController(
            DashboardViewConfiguration dashboardViewConfiguration,
            IDashboardCustomizationAppService dashboardCustomizationAppService)
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(TSTDashboardCustomizationConsts.DashboardNames.DefaultHostDashboard);
        }
    }
}