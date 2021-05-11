using System.Collections.Generic;
using Abp.Application.Services.Dto;
using AFIAT.TST.Authorization.Permissions.Dto;
using AFIAT.TST.Web.Areas.Area.Models.Common;

namespace AFIAT.TST.Web.Areas.Area.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}