using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AFIAT.TST.Authorization;

namespace AFIAT.TST
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(TSTApplicationSharedModule),
        typeof(TSTCoreModule)
        )]
    public class TSTApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TSTApplicationModule).GetAssembly());
        }
    }
}