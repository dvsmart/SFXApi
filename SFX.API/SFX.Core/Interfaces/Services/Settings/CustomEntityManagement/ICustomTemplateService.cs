using SFX.Dtos.CustomEntity;
using System.Threading.Tasks;
using SFX.Core.Dto.CustomEntity;

namespace SFX.Core.Interfaces.ServicesSettings.CustomEntityManagement
{
    public interface ICustomTemplateService
    {
        Task<TemplateResponseDto> GetTemplateDetail(int id);

        Task<TemplateResponseDto> UpdateTemplate(
            TemplateRequestDto createCustomTemplateRequest);

        Task<TemplateResponseDto> CreateTemplate(
            TemplateRequestDto createCustomTemplateRequest);
    }
}
