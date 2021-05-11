using Abp.Authorization;
using AFIAT.TST.Authorization.Roles;
using AFIAT.TST.Authorization.Users;

namespace AFIAT.TST.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
