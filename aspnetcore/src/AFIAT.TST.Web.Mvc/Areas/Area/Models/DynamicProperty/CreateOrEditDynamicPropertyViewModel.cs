using System.Collections.Generic;
using AFIAT.TST.DynamicEntityProperties.Dto;

namespace AFIAT.TST.Web.Areas.Area.Models.DynamicProperty
{
    public class CreateOrEditDynamicPropertyViewModel
    {
        public DynamicPropertyDto DynamicPropertyDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
