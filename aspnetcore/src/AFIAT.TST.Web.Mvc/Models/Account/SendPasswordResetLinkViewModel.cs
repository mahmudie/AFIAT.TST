using System.ComponentModel.DataAnnotations;

namespace AFIAT.TST.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}