using System.Collections.Generic;
using SFX.Domain.Response;

namespace SFX.Services.Interfaces.CustomEntity
{
    public interface ITemplateFormValueService
    {
        System.Threading.Tasks.Task<SaveResponseDto> Add(List<Domain.CustomEntity.CustomFieldValue> customFieldValues);
    }
}
