using System.Collections.Generic;
using AFIAT.TST.Authorization.Permissions.Dto;

namespace AFIAT.TST.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}