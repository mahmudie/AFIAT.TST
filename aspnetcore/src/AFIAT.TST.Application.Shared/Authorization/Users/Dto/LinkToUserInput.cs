using System.ComponentModel.DataAnnotations;
using Abp.Auditing;

namespace AFIAT.TST.Authorization.Users.Dto
{
    public class LinkToUserInput
    {
        public string TenancyName { get; set; }

        [Required]
        public string UsernameOrEmailAddress { get; set; }

        [Required]
        [DisableAuditing]
        public string Password { get; set; }
    }
}