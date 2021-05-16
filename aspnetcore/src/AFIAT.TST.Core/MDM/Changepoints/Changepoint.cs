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
    [Table("AbpChangepoints")]
    class Changepoint:FullAuditedEntity
    {
        public const int MaxLength = 250;
        [Required]
        [MaxLength(MaxLength)]
        public string ChangeName { get; set; }
        [Required]
        [MaxLength(MaxLength)]
        public string ChangeNameDari { get; set; }
        [Required]
        [MaxLength(MaxLength)]
        public string ChangeNamePashto { get; set; }
        [Required]
        [ForeignKey("Id")]
        public int CriteriaId { get; set; }
        public virtual Criteria Criteria { get; set; }
    }
}
