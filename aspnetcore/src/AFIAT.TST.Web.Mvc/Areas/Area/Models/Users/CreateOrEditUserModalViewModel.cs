using System.Linq;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using AFIAT.TST.Authorization.Users.Dto;
using AFIAT.TST.Security;
using AFIAT.TST.Web.Areas.Area.Models.Common;

namespace AFIAT.TST.Web.Areas.Area.Models.Users
{
    [AutoMapFrom(typeof(GetUserForEditOutput))]
    public class CreateOrEditUserModalViewModel : GetUserForEditOutput, IOrganizationUnitsEditViewModel
    {
        public bool CanChangeUserName => User.UserName != AbpUserBase.AdminUserName;

        public int AssignedRoleCount
        {
            get { return Roles.Count(r => r.IsAssigned); }
        }

        public bool IsEditMode => User.Id.HasValue;

        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }
    }
}