using System.Collections.Generic;
using AFIAT.TST.Authorization.Users.Dto;

namespace AFIAT.TST.Web.Areas.Area.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}