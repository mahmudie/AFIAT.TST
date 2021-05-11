using System.Collections.Generic;
using AFIAT.TST.Caching.Dto;

namespace AFIAT.TST.Web.Areas.Area.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}