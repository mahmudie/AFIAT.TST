using Abp.AspNetCore.Mvc.ViewComponents;

namespace AFIAT.TST.Web.Public.Views
{
    public abstract class TSTViewComponent : AbpViewComponent
    {
        protected TSTViewComponent()
        {
            LocalizationSourceName = TSTConsts.LocalizationSourceName;
        }
    }
}