using Abp.AutoMapper;
using Abp.Organizations;

namespace AFIAT.TST.Web.Areas.Area.Models.OrganizationUnits
{
    [AutoMapFrom(typeof(OrganizationUnit))]
    public class EditOrganizationUnitModalViewModel
    {
        public long? Id { get; set; }

        public string DisplayName { get; set; }
    }
}