using System.Collections.Generic;
using SFX.Core.Domain.Response;

namespace SFX.Services.Interfaces.CustomEntity
{
    public interface ITemplateFormValueService
    {
        System.Threading.Tasks.Task<SaveResponseDto> Add(List<Core.Domain.CustomEntity.CustomFieldValue> customFieldValues);
    }
}
