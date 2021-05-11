using Microsoft.Extensions.Configuration;

namespace AFIAT.TST.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
