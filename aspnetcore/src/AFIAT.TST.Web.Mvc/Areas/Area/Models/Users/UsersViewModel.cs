using System.Collections.Generic;
using Abp.Application.Services.Dto;
using AFIAT.TST.Authorization.Permissions.Dto;
using AFIAT.TST.Web.Areas.Area.Models.Common;

namespace AFIAT.TST.Web.Areas.Area.Models.Users
{
    public class UsersViewModel : IPermissionsEditViewModel
    {
        public string FilterText { get; set; }

        public List<ComboboxItemDto> Roles { get; set; }

        public bool OnlyLockedUsers { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}