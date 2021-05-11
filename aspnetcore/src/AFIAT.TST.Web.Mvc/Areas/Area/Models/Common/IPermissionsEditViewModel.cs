using System.Collections.Generic;
using AFIAT.TST.Authorization.Permissions.Dto;

namespace AFIAT.TST.Web.Areas.Area.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}