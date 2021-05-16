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
    [Table("AbpSections")]
    public class Section : FullAuditedEntity
    {
        public const int MaxSectionLength = 250;


        [Required]
        [MaxLength(MaxSectionLength)]
        public virtual string StandardName { get; set; }

        [Required]
        [MaxLength(MaxSectionLength)]
        public virtual string StandardNameDari { get; set; }

        [MaxLength(MaxSectionLength)]
        public virtual string StandardNamePashto { get; set; }

        [Required]
        [ForeignKey("Id")]
        public int AreaId { get; set; }

        public virtual Area Area {get;set;}

        public List<Standard> Standards { get; set; }

    }
}
