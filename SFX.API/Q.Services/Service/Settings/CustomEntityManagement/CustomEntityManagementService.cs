using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SFX.Domain;
using SFX.Dtos.CustomEntity;
using SFX.Services.Interfaces.Settings.CustomEntityManagement;

namespace SFX.Services.Service.Settings.CustomEntityManagement
{
    public class CustomEntityManagementService : ICustomEntityManagementService
    {
        private readonly IGenericRepository<Domain.CustomEntity.CustomEntityGroup> _customGroupRepository;
        private readonly IGenericRepository<Domain.CustomEntity.CustomEntity> _customTemplateRepository;
        private readonly IGenericRepository<Domain.CustomEntity.CustomTab> _customTabRepository;
        private readonly IGenericRepository<Domain.CustomEntity.CustomField> _customFieldRepository;

        public CustomEntityManagementService(
            IGenericRepository<Domain.CustomEntity.CustomEntityGroup> groupRepository,
            IGenericRepository<Domain.CustomEntity.CustomEntity> templateRepository,
            IGenericRepository<Domain.CustomEntity.CustomTab> tabRepository,
            IGenericRepository<Domain.CustomEntity.CustomField> fieldRepository)
        {
            _customGroupRepository = groupRepository;
            _customTemplateRepository = templateRepository;
            _customTabRepository = tabRepository;
            _customFieldRepository = fieldRepository;
        }

        public async Task<CustomDto> AddCustomGroup(CreateCustomGroupDto createCustomGroupRequest)
        {
            var customGroup = new Domain.CustomEntity.CustomEntityGroup
            {
                Id = createCustomGroupRequest.Id,
                Name = createCustomGroupRequest.GroupName,
                AddedDate = DateTime.UtcNow,
                AddedBy = 1,
                IsArchived = false,
                IsDeleted = false
            };
            var response = await _customGroupRepository.AddAsync(customGroup);
            return response.Id != default(int) ? new CustomDto
            {
                Id = response.Id,
                Caption = response.Name
            } : null;
        }

        public async Task<CustomDto> AddCustomTemplate(CreateCustomTemplateRequest createCustomTemplateRequest)
        {
            var template = new Domain.CustomEntity.CustomEntity
            {
                Id = createCustomTemplateRequest.Id,
                TemplateName = createCustomTemplateRequest.TemplateName,
                EntityGroupId = createCustomTemplateRequest.CustomGroupId,
                IsArchived = false,
                IsDeleted = false,
                AddedBy = 1,
                AddedDate = DateTime.UtcNow
            };
            var response = await _customTemplateRepository.AddAsync(template);
            return response.Id != default(int) ? new CustomDto
            {
                Id = response.Id,
                Caption = response.TemplateName
            } : null;
        }

        public async Task<CustomDto> AddCustomTemplateTab(CreateCustomTemplateTabRequest createCustomTemplateTabRequest)
        {
            var tab = new Domain.CustomEntity.CustomTab
            {
                Id = createCustomTemplateTabRequest.Id,
                Name = createCustomTemplateTabRequest.TabName,
                CustomEntityId = createCustomTemplateTabRequest.CustomTemplateId,
                IsArchived = false,
                IsDeleted = false,
                AddedBy = 1,
                AddedDate = DateTime.UtcNow
            };
            var response = await _customTabRepository.AddAsync(tab);
            return response.Id != default(int) ? new CustomDto
            {
                Id = response.Id,
                Caption = response.Name
            } : null;
        }

        public async Task<CustomDto> AddCustomTemplateTabFields(CreateCustomTabFieldRequest createCustomTabFieldRequest)
        {

            var field = new Domain.CustomEntity.CustomField
            {
                Id = createCustomTabFieldRequest.Id,
                FieldName = createCustomTabFieldRequest.Caption,
                CustomTabId = createCustomTabFieldRequest.CustomTemplateTabId,
                IsMandatory = createCustomTabFieldRequest.IsRequired,
                IsVisible = createCustomTabFieldRequest.IsVisible,
                FieldTypeId = createCustomTabFieldRequest.ControlTypeId,
                IsArchived = false,
                IsDeleted = false,
                AddedBy = 1,
                AddedDate = DateTime.UtcNow
            };
            var response = await _customFieldRepository.AddAsync(field);
            return response.Id != default(int) ? new CustomDto
            {
                Id = response.Id,
                Caption = response.FieldName
            } : null;
        }

        public async Task<List<CustomGroupDto>> GetCustomGroups()
        {
            var customGroups = await _customGroupRepository.GetAllAsync();
            if (customGroups == null) return new List<CustomGroupDto>();
            return customGroups.Select(cg => new CustomGroupDto
            {
                Id = cg.Id,
                GroupName = cg.Name,
            }).ToList();
        }

        public async Task<List<CustomTabFieldResponseDto>> GetCustomTabFields(int templateId)
        {
            var customTabFields = await _customFieldRepository.FindAllAsync(x => x.CustomTab.CustomEntityId == templateId);
            if (customTabFields == null) return new List<CustomTabFieldResponseDto>();
            return customTabFields.Select(ct => new CustomTabFieldResponseDto
            {
                Id = ct.Id,
                Caption = ct.FieldName,
                ControlType = ct.FieldType.Caption,
            }).ToList();
        }

        public async Task<CustomGroupTemplateDto> GetCustomTemplates(int groupId)
        {
            var customGroup = await _customGroupRepository.FindByIdAsync(groupId);
            var customGroupTemplateDto = new CustomGroupTemplateDto();
            if (customGroup == null) return customGroupTemplateDto;
            if (customGroup.CustomEntities.Any())
            {
                customGroupTemplateDto.CustomTemplates = customGroup.CustomEntities.Select(ct => new CustomTemplateDto
                {
                    Id = ct.Id,
                    TemplateName = ct.TemplateName,
                }).ToList();
            }

            customGroupTemplateDto.GroupId = customGroup.Id;
            customGroupTemplateDto.GroupName = customGroup.Name;
            return customGroupTemplateDto;
        }

        public async Task<CustomTemplateTabDto> GetCustomTemplateTabs(int templateId)
        {
            var customTemplateTabs = await _customTemplateRepository.FindByIdAsync(templateId);
            if (customTemplateTabs == null) return new CustomTemplateTabDto();
            var customTemplateTabDto = new CustomTemplateTabDto();
            
            if (customTemplateTabs.CustomTabs.Any())
            {
                customTemplateTabDto.TemplateTabs = customTemplateTabs.CustomTabs.Select(ct => new CustomDto
                {
                    Id = ct.Id,
                    Caption = ct.Name,
                }).ToList();
            }

            customTemplateTabDto.TemplateName = customTemplateTabs.TemplateName;
            customTemplateTabDto.Id = customTemplateTabs.Id;
            return customTemplateTabDto;
        }
    }
}
