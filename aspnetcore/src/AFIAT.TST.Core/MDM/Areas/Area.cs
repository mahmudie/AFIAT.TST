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
    [Table("AbpAreas")]
    public class Area : FullAuditedEntity
    {
        public const int MaxAreaLength = 120;

        [Required]
        [MaxLength(MaxAreaLength)]
        public virtual string AreaNameEng { get; set; }

        [Required]
        [MaxLength(MaxAreaLength)]
        public virtual string AreaNameDari { get; set; }

        [MaxLength(MaxAreaLength)]
        public virtual string AreaNamePashto { get; set; }

        public List<Section> Sections { get; set; }

    }
}
