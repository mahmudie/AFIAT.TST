using System.Collections.Generic;
using AFIAT.TST.DynamicEntityProperties.Dto;

namespace AFIAT.TST.Web.Areas.Area.Models.DynamicEntityProperty
{
    public class CreateEntityDynamicPropertyViewModel
    {
        public string EntityFullName { get; set; }

        public List<string> AllEntities { get; set; }

        public List<DynamicPropertyDto> DynamicProperties { get; set; }
    }
}
