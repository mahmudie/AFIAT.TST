using Abp.Domain.Services;

namespace AFIAT.TST
{
    public abstract class TSTDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected TSTDomainServiceBase()
        {
            LocalizationSourceName = TSTConsts.LocalizationSourceName;
        }
    }
}
