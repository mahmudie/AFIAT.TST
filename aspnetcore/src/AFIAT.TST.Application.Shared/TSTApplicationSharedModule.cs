using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AFIAT.TST
{
    [DependsOn(typeof(TSTCoreSharedModule))]
    public class TSTApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TSTApplicationSharedModule).GetAssembly());
        }
    }
}