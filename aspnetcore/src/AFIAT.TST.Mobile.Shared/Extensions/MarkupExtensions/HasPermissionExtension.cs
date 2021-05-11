using System;
using AFIAT.TST.Core;
using AFIAT.TST.Core.Dependency;
using AFIAT.TST.Services.Permission;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AFIAT.TST.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HasPermissionExtension : IMarkupExtension
    {
        public string Text { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return false;
            }

            var permissionService = DependencyResolver.Resolve<IPermissionService>();
            return permissionService.HasPermission(Text);
        }
    }
}