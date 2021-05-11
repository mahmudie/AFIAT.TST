using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using AFIAT.TST.Configure;
using AFIAT.TST.Startup;
using AFIAT.TST.Test.Base;

namespace AFIAT.TST.GraphQL.Tests
{
    [DependsOn(
        typeof(TSTGraphQLModule),
        typeof(TSTTestBaseModule))]
    public class TSTGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TSTGraphQLTestModule).GetAssembly());
        }
    }
}