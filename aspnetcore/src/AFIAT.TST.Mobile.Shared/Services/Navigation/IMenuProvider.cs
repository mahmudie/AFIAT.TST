using System.Collections.Generic;
using MvvmHelpers;
using AFIAT.TST.Models.NavigationMenu;

namespace AFIAT.TST.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}