using System.Collections.Generic;
using AFIAT.TST.DashboardCustomization.Dto;

namespace AFIAT.TST.Web.Areas.Area.Models.CustomizableDashboard
{
    public class AddWidgetViewModel
    {
        public List<WidgetOutput> Widgets { get; set; }

        public string DashboardName { get; set; }

        public string PageId { get; set; }
    }
}
