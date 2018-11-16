using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Core.Domain.CustomEntity;
using SFX.Core.Domain.Response;
using SFX.Dtos.CustomEntity;

namespace SFX.Core.Interfaces.ServicesCustomEntity
{
    public interface ITemplateTabService
    {
        Task<IEnumerable<CustomTab>> GetAll();

        Task<SaveResponseDto> Add(CustomTab customTab);

        Task<SaveResponseDto> UpdateAsync(CustomTab customTab);

        Task<SaveResponseDto> Delete(int id);

        Task<CustomTab> GetById(int id);

        Task<CustomTemplateTabDto> GetTabsById(int id);

    }
}
