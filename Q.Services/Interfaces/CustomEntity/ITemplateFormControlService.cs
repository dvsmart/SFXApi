using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Domain.CustomEntity;
using SFX.Domain.Response;

namespace SFX.Services.Interfaces.CustomEntity
{
    public interface ITemplateFormControlService
    {
        Task<IEnumerable<CustomField>> GetAll();

        Task<SaveResponseDto> Add(CustomField customField);

        Task<SaveResponseDto> UpdateAsync(CustomField customField);

        Task<SaveResponseDto> DeleteAsync(int id);

        Task<IEnumerable<CustomField>> GetFieldsByTabId(int id);
    }
}
