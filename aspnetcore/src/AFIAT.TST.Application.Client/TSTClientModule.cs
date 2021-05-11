using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AFIAT.TST
{
    public class TSTClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TSTClientModule).GetAssembly());
        }
    }
}
