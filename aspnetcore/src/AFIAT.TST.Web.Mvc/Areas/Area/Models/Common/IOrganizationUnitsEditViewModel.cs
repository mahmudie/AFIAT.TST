using System.Collections.Generic;
using AFIAT.TST.Organizations.Dto;

namespace AFIAT.TST.Web.Areas.Area.Models.Common
{
    public interface IOrganizationUnitsEditViewModel
    {
        List<OrganizationUnitDto> AllOrganizationUnits { get; set; }

        List<string> MemberedOrganizationUnits { get; set; }
    }
}