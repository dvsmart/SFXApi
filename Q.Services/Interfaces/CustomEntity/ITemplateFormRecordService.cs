using System.Threading.Tasks;
using SFX.Domain;
using SFX.Domain.CustomEntity;
using SFX.Domain.Response;
using SFX.Dtos.CustomEntity;

namespace SFX.Services.Interfaces.CustomEntity
{
    public interface ITemplateFormRecordService
    {
        Task<SaveResponseDto> Add(CustomEntityInstance customEntityInstance);

        Task<PagedResult<CustomEntityInstance>> GetAll(int templateId, int page, int? pageSize);

        Task<CustomEntityRecordDto> GetById(int id);

        Task<SaveResponseDto> Delete(int id);

    }
}
