using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using AFIAT.TST.Authorization.Users;
using AFIAT.TST.MultiTenancy;

namespace AFIAT.TST.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}