using System.Collections.Generic;
using AFIAT.TST.Authorization.Delegation;
using AFIAT.TST.Authorization.Users.Delegation.Dto;

namespace AFIAT.TST.Web.Areas.Area.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }
        
        public List<UserDelegationDto> UserDelegations { get; set; }
    }
}
