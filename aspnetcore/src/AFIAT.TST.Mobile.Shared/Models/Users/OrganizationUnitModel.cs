using Abp.AutoMapper;
using AFIAT.TST.Organizations.Dto;

namespace AFIAT.TST.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}