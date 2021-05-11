using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AFIAT.TST
{
    [DependsOn(typeof(TSTClientModule), typeof(AbpAutoMapperModule))]
    public class TSTXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TSTXamarinSharedModule).GetAssembly());
        }
    }
}