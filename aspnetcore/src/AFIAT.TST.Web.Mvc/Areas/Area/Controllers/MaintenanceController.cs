using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using AFIAT.TST.Authorization;
using AFIAT.TST.Caching;
using AFIAT.TST.Web.Areas.Area.Models.Maintenance;
using AFIAT.TST.Web.Controllers;

namespace AFIAT.TST.Web.Areas.Area.Controllers
{
    [Area("Area")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Host_Maintenance)]
    public class MaintenanceController : TSTControllerBase
    {
        private readonly ICachingAppService _cachingAppService;

        public MaintenanceController(ICachingAppService cachingAppService)
        {
            _cachingAppService = cachingAppService;
        }

        public ActionResult Index()
        {
            var model = new MaintenanceViewModel
            {
                Caches = _cachingAppService.GetAllCaches().Items
            };

            return View(model);
        }
    }
}