using Abp.AutoMapper;
using AFIAT.TST.Localization.Dto;

namespace AFIAT.TST.Web.Areas.Area.Models.Languages
{
    [AutoMapFrom(typeof(GetLanguageForEditOutput))]
    public class CreateOrEditLanguageModalViewModel : GetLanguageForEditOutput
    {
        public bool IsEditMode => Language.Id.HasValue;
    }
}