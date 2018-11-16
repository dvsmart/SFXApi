using System.Threading.Tasks;
 
using SFX.Core.Domain.CustomEntity;
using SFX.Core.Domain.Response;
using SFX.Core.Interfaces;
using SFX.Dtos.CustomEntity;

namespace SFX.Services.Interfaces.CustomEntity
{
    public interface ITemplateFormRecordService
    {
        Task<SaveResponseDto> Add(CustomEntityInstance customEntityInstance);

        Task<PagedResult<CustomEntityInstance>> GetAll(int templateId, int page, int? pageSize);

        //Task<CustomEntityRecordDto> GetById(int id);

        Task<SaveResponseDto> Delete(int id);

    }
}
