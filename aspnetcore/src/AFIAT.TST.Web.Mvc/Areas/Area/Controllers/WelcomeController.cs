using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using AFIAT.TST.Web.Controllers;

namespace AFIAT.TST.Web.Areas.Area.Controllers
{
    [Area("Area")]
    [AbpMvcAuthorize]
    public class WelcomeController : TSTControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}