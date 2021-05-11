using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using AFIAT.TST.DynamicEntityProperties.Dto;
using AFIAT.TST.DynamicEntityPropertyValues.Dto;

namespace AFIAT.TST.DynamicEntityProperties
{
    public interface IDynamicEntityPropertyValueAppService
    {
        Task<DynamicEntityPropertyValueDto> Get(int id);

        Task<ListResultDto<DynamicEntityPropertyValueDto>> GetAll(GetAllInput input);

        Task Add(DynamicEntityPropertyValueDto input);

        Task Update(DynamicEntityPropertyValueDto input);

        Task Delete(int id);

        Task<GetAllDynamicEntityPropertyValuesOutput> GetAllDynamicEntityPropertyValues(GetAllDynamicEntityPropertyValuesInput input);
    }
}
