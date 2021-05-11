using Abp.AutoMapper;
using AFIAT.TST.Authorization.Users;
using AFIAT.TST.Authorization.Users.Dto;
using AFIAT.TST.Web.Areas.Area.Models.Common;

namespace AFIAT.TST.Web.Areas.Area.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }
    }
}