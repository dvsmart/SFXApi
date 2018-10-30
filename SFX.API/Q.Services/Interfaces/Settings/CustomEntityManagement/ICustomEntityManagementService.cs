using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Dtos.CustomEntity;

namespace SFX.Services.Interfaces.Settings.CustomEntityManagement
{
    public interface ICustomEntityManagementService
    {
        Task<List<CustomGroupDto>> GetCustomGroups();

        Task<List<CustomTemplateDto>> GetCustomTemplates();

        Task<CustomGroupTemplateDto> GetCustomTemplates(int groupId);

        Task<CustomTemplateTabDto> GetCustomTemplateTabs(int templateId);

        Task<HashSet<CustomFieldResponseDto>> GetCustomFields(int templateId);

        Task<List<CustomTabFieldResponseDto>> GetCustomTabFields(int tabId);

        Task<CustomDto> AddCustomGroup(CreateCustomGroupDto createCustomGroupRequest);

        Task<CustomDto> AddCustomTemplate(CreateCustomTemplateRequest createCustomTemplateRequest);

        Task<CustomDto> AddCustomTemplateTab(CreateCustomTemplateTabRequest createCustomTemplateTabRequest);

        Task<CustomDto> AddCustomTemplateTabFields(CreateFieldRequest createCustomTabFieldRequest);

        Task<TemplateResponse> GetTemplateDetail(int templateId);

    }
}
