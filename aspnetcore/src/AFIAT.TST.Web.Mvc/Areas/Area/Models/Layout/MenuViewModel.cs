using Abp.Application.Navigation;

namespace AFIAT.TST.Web.Areas.Area.Models.Layout
{
    public class MenuViewModel
    {
        public UserMenu Menu { get; set; }

        public string CurrentPageName { get; set; }
    }
}