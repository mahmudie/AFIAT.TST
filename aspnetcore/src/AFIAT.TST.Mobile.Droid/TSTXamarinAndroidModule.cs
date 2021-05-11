using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AFIAT.TST
{
    [DependsOn(typeof(TSTXamarinSharedModule))]
    public class TSTXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TSTXamarinAndroidModule).GetAssembly());
        }
    }
}