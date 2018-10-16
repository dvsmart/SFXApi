using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Domain.Response;
using SFX.Dtos.CustomEntity;

namespace SFX.Services.Interfaces.CustomEntity
{
    public interface ITemplateService
    {
        Task<IEnumerable<Domain.CustomEntity.CustomEntity>> GetTemplates();

        Task<SaveResponseDto> AddTemplate(Domain.CustomEntity.CustomEntity customEntity);

        Task<SaveResponseDto> UpdateTemplate(Domain.CustomEntity.CustomEntity customEntity);

        Task<SaveResponseDto> DeleteTemplate(int id);

        Task<CustomEntityDefintionDto> GetTemplateByIdAsync(int id);

        Task<CustomEntityGroupDto> GetTemplateByGroupId(int groupId);

        Task<CustomEntityTemplate> GetTemplateBasicInformationByIdAsync(int id);

    }
}
