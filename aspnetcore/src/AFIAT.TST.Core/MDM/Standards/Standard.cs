using Abp.Domain.Entities.Auditing;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AFIAT.TST.MDM
{
    [Table("AbpStandards")]
    public class Standard : FullAuditedEntity
    {
        public const int MaxStandardLength = 250;
        [Required]
        [MaxLength(MaxStandardLength)]
        public string StandardName { get; set; }
        [Required]
        [MaxLength(MaxStandardLength)]
        public string StandardNameDari { get; set; }
        [Required]
        [MaxLength(MaxStandardLength)]
        public string StandardNamePashto { get; set; }
        [Required]
        [ForeignKey("Id")]
        public int SectionId { get; set; }
        public virtual Section Section { get; set; }

        List<Criteria> Criterias { get; set; }

    }
}