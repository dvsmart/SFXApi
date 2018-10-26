using SFX.Dtos.CustomEntity;
using System.Threading.Tasks;

namespace SFX.Services.Interfaces.Settings.CustomEntityManagement
{
    public interface ICustomTemplateService
    {
        Task<CustomTemplateResponse> GetTemplateDetail(int id);

        Task<CustomTemplateResponse> UpdateTemplate(
            CreateCustomTemplateRequest createCustomTemplateRequest);

        Task<CustomTemplateResponse> CreateTemplate(
            CreateCustomTemplateRequest createCustomTemplateRequest);
    }
}
