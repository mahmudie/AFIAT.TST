using System.Collections.Generic;
using Abp.Authorization;
using Abp.DynamicEntityProperties;
using AFIAT.TST.Authorization;

namespace AFIAT.TST.DynamicEntityProperties
{
    [AbpAuthorize(AppPermissions.Pages_Administration_DynamicProperties)]
    public class DynamicEntityPropertyDefinitionAppService : TSTAppServiceBase, IDynamicEntityPropertyDefinitionAppService
    {
        private readonly IDynamicEntityPropertyDefinitionManager _dynamicEntityPropertyDefinitionManager;

        public DynamicEntityPropertyDefinitionAppService(IDynamicEntityPropertyDefinitionManager dynamicEntityPropertyDefinitionManager)
        {
            _dynamicEntityPropertyDefinitionManager = dynamicEntityPropertyDefinitionManager;
        }

        public List<string> GetAllAllowedInputTypeNames()
        {
            return _dynamicEntityPropertyDefinitionManager.GetAllAllowedInputTypeNames();
        }

        public List<string> GetAllEntities()
        {
            return _dynamicEntityPropertyDefinitionManager.GetAllEntities();
        }
    }
}
