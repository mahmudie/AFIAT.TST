using System.Collections.Generic;
using AFIAT.TST.Editions.Dto;

namespace AFIAT.TST.Web.Areas.Area.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}