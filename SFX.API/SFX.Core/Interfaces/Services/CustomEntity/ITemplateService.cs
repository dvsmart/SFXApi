using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Core.Domain.Response;
using SFX.Dtos.CustomEntity;

namespace SFX.Core.Interfaces.ServicesCustomEntity
{
    public interface ITemplateService
    {
        Task<IEnumerable<Core.Domain.CustomEntity.CustomEntity>> GetTemplates();

        Task<SaveResponseDto> AddTemplate(Core.Domain.CustomEntity.CustomEntity customEntity);

        Task<SaveResponseDto> UpdateTemplate(Core.Domain.CustomEntity.CustomEntity customEntity);

        Task<SaveResponseDto> DeleteTemplate(int id);

        Task<CustomEntityDefintionDto> GetTemplateByIdAsync(int id);

        Task<CustomEntityGroupDto> GetTemplateByGroupId(int groupId);

        Task<CustomEntityTemplate> GetTemplateBasicInformationByIdAsync(int id);

    }
}
