using System.ComponentModel.DataAnnotations;

namespace AFIAT.TST.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}