using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFIAT.TST.MDM
{
    [Table("AbpFacilityTypes")]
    class FacilityType:FullAuditedEntity
    {
        public const int MaxLength = 250;
        public const int MaxAbbrvType = 10;

        [Required]
        [MaxLength(MaxLength)]
        public string TypeName { get; set; }
        [Required]
        [MaxLength(MaxLength)]
        public string TypeNameDari { get; set; }
        [Required]
        [MaxLength(MaxLength)]
        public string TypeNamePashto { get; set; }
        [Required]
        [MaxLength(MaxAbbrvType)]
        public string TypeAbbrv { get; set; }
    }
}
