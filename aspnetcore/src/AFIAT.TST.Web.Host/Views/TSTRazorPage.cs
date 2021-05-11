using Abp.AspNetCore.Mvc.Views;

namespace AFIAT.TST.Web.Views
{
    public abstract class TSTRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected TSTRazorPage()
        {
            LocalizationSourceName = TSTConsts.LocalizationSourceName;
        }
    }
}
