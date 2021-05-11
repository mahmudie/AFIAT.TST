using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AFIAT.TST.Startup
{
    [DependsOn(typeof(TSTCoreModule))]
    public class TSTGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TSTGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}