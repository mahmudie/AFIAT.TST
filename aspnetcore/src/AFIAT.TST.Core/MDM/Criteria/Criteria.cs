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
    [Table("AbpCriterion")]
    class Criteria:FullAuditedEntity
    {
        public const int MaxLength = 250;
        [Required]
        [MaxLength(MaxLength)]
        public string CriteriaName { get; set; }
        [Required]
        [MaxLength(MaxLength)]
        public string CriteriaNameDari { get; set; }
        [Required]
        [MaxLength(MaxLength)]
        public string CriteriaNamePashto { get; set; }
        [Required]
        [ForeignKey("Id")]
        public int StandardId { get; set; }
        public virtual Standard Standard { get; set; }

        public List<Changepoint> Changepoints { get; set; }
    }
}
