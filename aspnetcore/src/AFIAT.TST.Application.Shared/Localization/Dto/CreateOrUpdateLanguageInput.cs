using System.ComponentModel.DataAnnotations;

namespace AFIAT.TST.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}