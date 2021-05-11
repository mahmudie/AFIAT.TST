using Abp.AspNetCore.Mvc.Authorization;
using AFIAT.TST.Authorization;
using AFIAT.TST.Storage;
using Abp.BackgroundJobs;

namespace AFIAT.TST.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}