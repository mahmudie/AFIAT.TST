using System.Threading.Tasks;
using Abp.Authorization.Users;
using AFIAT.TST.Authorization.Users;

namespace AFIAT.TST.Authorization
{
    public static class UserManagerExtensions
    {
        public static async Task<User> GetAdminAsync(this UserManager userManager)
        {
            return await userManager.FindByNameAsync(AbpUserBase.AdminUserName);
        }
    }
}
