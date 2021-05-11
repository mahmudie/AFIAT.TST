using Microsoft.AspNetCore.Mvc;
using AFIAT.TST.Web.Controllers;

namespace AFIAT.TST.Web.Public.Controllers
{
    public class HomeController : TSTControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}