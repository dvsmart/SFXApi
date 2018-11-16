using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Core.Domain.CustomEntity;
using SFX.Core.Domain.Response;

namespace SFX.Core.Interfaces.ServicesCustomEntity
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
