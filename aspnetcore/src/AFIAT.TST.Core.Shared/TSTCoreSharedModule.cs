using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AFIAT.TST
{
    public class TSTCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TSTCoreSharedModule).GetAssembly());
        }
    }
}