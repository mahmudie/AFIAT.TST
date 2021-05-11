using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFIAT.TST.MDM.Areas
{
    [Table("AbpAreas")]
    public class Area : FullAuditedEntity, IHasCreationTime
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

        public override long? LastModifierUserId { get; set; }
        public override DateTime CreationTime { get; set; }
        public override DateTime? LastModificationTime { get; set; }
        public Area()
        {
            CreationTime = DateTime.Now;
        }
    }
}
