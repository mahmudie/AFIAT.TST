using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AFIAT.TST
{
    [DependsOn(typeof(TSTXamarinSharedModule))]
    public class TSTXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TSTXamarinIosModule).GetAssembly());
        }
    }
}