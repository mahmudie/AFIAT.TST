using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace AFIAT.TST.Web.Public.Views
{
    public abstract class TSTRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected TSTRazorPage()
        {
            LocalizationSourceName = TSTConsts.LocalizationSourceName;
        }
    }
}
