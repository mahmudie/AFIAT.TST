using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using AFIAT.TST.Configuration;

namespace AFIAT.TST.Test.Base
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(TSTTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
