using System.Collections.Generic;
using SFX.Core.Domain.Response;

namespace SFX.Core.Interfaces.ServicesCustomEntity
{
    public interface ITemplateFormValueService
    {
        System.Threading.Tasks.Task<SaveResponseDto> Add(List<Core.Domain.CustomEntity.CustomFieldValue> customFieldValues);
    }
}
