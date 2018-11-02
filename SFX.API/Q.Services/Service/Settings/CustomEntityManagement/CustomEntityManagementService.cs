using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
                EntityGroupId = createCustomTemplateRequest.CategoryId,
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

        public async Task<CustomTabDto> AddCustomTemplateTab(CreateCustomTemplateTabRequest createCustomTemplateTabRequest)
        {
            var tab = new Domain.CustomEntity.CustomTab
            {
                Id = createCustomTemplateTabRequest.Id,
                Name = createCustomTemplateTabRequest.Caption,
                CustomEntityId = createCustomTemplateTabRequest.CustomTemplateId,
                IsArchived = false,
                IsDeleted = false,
                AddedBy = 1,
                AddedDate = DateTime.UtcNow
            };
            var response = await _customTabRepository.AddAsync(tab);
            return MapCustomTabDto(response);
        }

        public async Task<CustomTabFieldResponseDto> AddCustomTemplateTabFields(CreateFieldRequest createCustomTabFieldRequest)
        {

            var field = new Domain.CustomEntity.CustomField
            {
                Id = createCustomTabFieldRequest.Id,
                FieldName = createCustomTabFieldRequest.Caption,
                CustomTabId = createCustomTabFieldRequest.TabId,
                IsMandatory = createCustomTabFieldRequest.IsRequired,
                IsVisible = createCustomTabFieldRequest.IsVisible,
                FieldTypeId = createCustomTabFieldRequest.ControlTypeId,
                CustomEntityId = createCustomTabFieldRequest.TemplateId,
                IsArchived = false,
                IsDeleted = false,
                AddedBy = 1,
                AddedDate = DateTime.UtcNow
            };
            var response = await _customFieldRepository.AddAsync(field);
            return response.Id != default(int) ? new CustomTabFieldResponseDto
            {
                Id = response.Id,
                Caption = response.FieldName,
                TabId = response.CustomTabId.GetValueOrDefault(),
                IsRequired = response.IsMandatory.GetValueOrDefault(),
                TabName = response.CustomTab.Name,
                SortOrder = response.SortOrder ?? 1,
                ControlType = response.FieldType.Caption,
                Key = $"field_{response.Id}",
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

        public async Task<List<CustomTemplateDto>> GetCustomTemplates()
        {
            var templates = await _customTemplateRepository.GetAllAsync();
            if (templates == null) return new List<CustomTemplateDto>();

            return templates.Where(x => x.EntityGroupId == null).Select(x => new CustomTemplateDto
            {
                Id = x.Id,
                TemplateName = x.TemplateName
            }).ToList();
        }

        public async Task<List<CustomTabFieldResponseDto>> GetCustomTabFields(int tabId)
        {
            var customTabFields = await _customFieldRepository.FindAllAsync(x => x.CustomTabId == tabId);
            if (customTabFields == null) return new List<CustomTabFieldResponseDto>();
            return customTabFields.Select(response => new CustomTabFieldResponseDto
            {
                Id = response.Id,
                Caption = response.FieldName,
                TabId = response.CustomTabId.GetValueOrDefault(),
                IsRequired = response.IsMandatory.GetValueOrDefault(),
                TabName = response.CustomTab.Name,
                SortOrder = response.SortOrder ?? 1,
                ControlType = response.FieldType.Caption,
                Key = $"field_{response.Id}",
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

        public async Task<TemplateResponse> GetTemplateDetail(int templateId)
        {
            var template = await _customTemplateRepository.FindByIdAsync(templateId);
            if (template == null) return new TemplateResponse();
            var templateDetail = new TemplateResponse
            {
                Id = template.Id,
                TemplateName = template.TemplateName,
                Tabs = template.CustomTabs.Select(x => new TabResponse
                {
                    TabId = x.Id,
                    TabName = x.Name,
                    AddedBy = "vijay",
                    AddedOn = x.AddedDate,
                    ModifiedBy = x.ModifiedBy == default(int) ? null : "vijayk",
                    ModifiedOn = x.ModifiedDate,
                    IsVisible = x.IsVisible,
                    FieldsCount = x.CustomFields.Count,
                    Fields = x.CustomFields.Select(ctf => new FieldResponse
                    {
                        ModifiedOn = ctf.ModifiedDate,
                        ModifiedBy = ctf.ModifiedBy == default(int) ? null : "vijayk",
                        AddedOn = ctf.AddedDate,
                        AddedBy = "vijayk",
                        TabId = ctf.CustomTabId,
                        Value = ctf.DefaultValue,
                        FieldCaption = ctf.FieldName,
                        FieldName = $"fieldId_{ctf.Id}",
                        FieldId = ctf.Id,
                        IsRequired = ctf.IsMandatory.GetValueOrDefault(),
                        IsVisible = ctf.IsVisible.GetValueOrDefault(),
                        FieldType = ctf.FieldType.Caption

                    }).ToHashSet()
                }).ToHashSet(),
                Fields = template.CustomFields.Select(cf => new FieldResponse
                {
                    ModifiedOn = cf.ModifiedDate,
                    ModifiedBy = cf.ModifiedBy == default(int) ? null : "vijayk",
                    AddedOn = cf.AddedDate,
                    AddedBy = "vijayk",
                    TabId = cf.CustomTabId,
                    Value = cf.DefaultValue,
                    FieldCaption = cf.FieldName,
                    FieldName = $"fieldId_{cf.Id}",
                    FieldId = cf.Id,
                    IsRequired = cf.IsMandatory.GetValueOrDefault(),
                    IsVisible = cf.IsVisible.GetValueOrDefault(),
                    FieldType = cf.FieldType.Caption
                }).ToHashSet()
            };
            return templateDetail;
        }

        public async Task<HashSet<CustomFieldResponseDto>> GetCustomFields(int templateId)
        {
            var template = await _customTemplateRepository.FindByIdAsync(templateId);
            if (template == null) return new HashSet<CustomFieldResponseDto>();

            var tabIds = template.CustomTabs?.Where(x => x.CustomFields.Any()).Select(x => x.Id).ToHashSet();
            var tabFields = _customFieldRepository.FindAll(x => tabIds.Contains(x.Id)).Select(f =>
                new CustomFieldResponseDto()
                {
                    Id = f.Id,
                    TabId = f.CustomTabId.GetValueOrDefault(),
                    TabName = f.CustomTab.Name,
                    IsRequired = f.IsMandatory.GetValueOrDefault(),
                    Caption = f.FieldName,
                    ControlType = f.FieldType.Caption,
                    Key = $"field_{f.Id}",
                    SortOrder = f.SortOrder ?? 1
                }).ToArray();

            var fields = template.CustomFields?.Select(f => new CustomFieldResponseDto
            {
                Id = f.Id,
                TemplateName = f.CustomEntity.TemplateName,
                IsRequired = f.IsMandatory.GetValueOrDefault(),
                Caption = f.FieldName,
                ControlType = f.FieldType.Caption,
                TemplateId = f.CustomEntityId.GetValueOrDefault(),
                Key = $"field_{f.Id}",
                SortOrder = f.SortOrder ?? 1
            }).ToArray();

            var totalFields = tabFields.Union(fields).ToHashSet();
            return totalFields;
        }

        public async Task<CustomTabDto> GetTabDetail(int tabId)
        {
            var tabDetail = await _customTabRepository.FindByIdAsync(tabId);
            if (tabDetail == null) return new CustomTabDto();
            return MapCustomTabDto(tabDetail);
        }

        public async Task<bool> DeleteCustomTab(int id)
        {
            var tab = await _customTabRepository.FindByIdAsync(id);
            var response = await _customTabRepository.DeleteAsync(tab);
            return response > 0 ? true : false;
        }

        public async Task<CustomTabDto> UpdateCustomTab(CreateCustomTemplateTabRequest createCustomTemplateTabRequest)
        {
            var tab = await _customTabRepository.FindByIdAsync(createCustomTemplateTabRequest.Id);
            var tabDetail = await _customTabRepository.UpdateAsync(tab, tab.Id);
            if (tabDetail == null) return new CustomTabDto();
            return MapCustomTabDto(tabDetail);
        }

        private CustomTabDto MapCustomTabDto(Domain.CustomEntity.CustomTab customTab)
        {
            return new CustomTabDto()
            {
                Id = customTab.Id,
                Caption = customTab.Name,
                IsVisible = customTab.IsVisible,
                CustomTemplateId = customTab.CustomEntityId,
                SortOrder = customTab.SortOrder ?? 1,
                IsOptional = customTab.IsOptional
            };
        }

        public async Task<CustomTabFieldResponseDto> GetCustomFieldDetail(int fieldId)
        {
            var field = await _customFieldRepository.FindByIdAsync(fieldId);
            if(field == null) return  new CustomTabFieldResponseDto();
            var fieldDto = new CustomTabFieldResponseDto
            {
                Id = field.Id,
                TabId = field.CustomTabId.GetValueOrDefault(),
                TabName = field.CustomTab.Name,
                IsRequired = field.IsMandatory.GetValueOrDefault(),
                Caption = field.FieldName,
                SortOrder = field.SortOrder ?? 1,
                ControlType = field.FieldType.Caption,
                Key = $"field_{field.Id}",
                ControlTypeId = field.FieldTypeId
            };
            return fieldDto;
        }
    }
}
