using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFIAT.TST.Authorization.Permissions.Dto;

namespace AFIAT.TST.Web.Areas.Area.Models.Common.Modals
{
    public class PermissionTreeModalViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }
        public List<string> GrantedPermissionNames { get; set; }
    }
}
