﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SFX.Core.Domain.CustomEntity;
using SFX.Core.Domain.Response;
using SFX.Core.Interfaces.Repositories;
using SFX.Core.Interfaces.ServicesCustomEntity;

namespace SFX.Services.CustomEntity
{
    public class TemplateService : ITemplateService
    {
        private readonly IGenericRepository<Core.Domain.CustomEntity.CustomEntity> _customTemplateRepository;
        private readonly IGenericRepository<CustomEntityGroup> _customGroupRepository;

        public TemplateService(IGenericRepository<Core.Domain.CustomEntity.CustomEntity> customTemplateRepository, IGenericRepository<CustomEntityGroup> customGroupRepository)
        {
            _customTemplateRepository = customTemplateRepository;
            _customGroupRepository = customGroupRepository;
        }
        public async Task<SaveResponseDto> AddTemplate(Core.Domain.CustomEntity.CustomEntity customEntity)
        {
            var res = await _customTemplateRepository.AddAsync(customEntity);
            return new SaveResponseDto
            {
                SaveSuccessful = res != null,
                SavedEntityId = customEntity.Id
            };
        }

        public async Task<SaveResponseDto> DeleteTemplate(int id)
        {
            var ceGroup = await _customTemplateRepository.FindAsync(x=>x.Id == id);
            var response = await _customTemplateRepository.DeleteAsync(ceGroup);
            return new SaveResponseDto
            {
                SavedEntityId = id,
                SaveSuccessful = response != default(int)
            };
        }

        public async Task<CustomEntityTemplate> GetTemplateBasicInformationByIdAsync(int id)
        {
            var ce = await _customTemplateRepository.FindAsync(x => x.Id == id);
            if (ce == null) return new CustomEntityTemplate();
            return new CustomEntityTemplate
            {
                GroupName = ce.EntityGroup.Name,
                Id = ce.Id,
                TemplateName = ce.TemplateName,
                GroupId = ce.EntityGroupId.GetValueOrDefault()
            };
        }

        public async Task<CustomEntityDefintionDto> GetTemplateByIdAsync(int id)
        {
            var ce = await _customTemplateRepository.FindAsync(x => x.Id == id);
            if (ce == null) return new CustomEntityDefintionDto();
            var tabFields = ce.CustomTabs.Select(x => new TemplateTabDto()
            {
                TabName = x.Name,
                Id = x.Id,
                SortOrder = x.SortOrder,
                IsVisible = x.IsVisible,
                Fields = x.CustomFields.Select(y => new TabFieldDto()
                {
                    Caption = y.FieldName,
                    SortOrder = y.SortOrder.GetValueOrDefault(),
                    Id = y.Id,
                    Type = y.FieldType.Type,
                    IsVisible = y.IsVisible ?? true,
                    IsRequired = y.IsMandatory ?? false,
                }).ToList()
            }).ToList();

            var customEntityRecordDto = new CustomEntityDefintionDto
            {
                Id = ce.Id,
                TemplateName = ce.TemplateName,
                Tabs = tabFields,
                GroupName = ce.EntityGroup?.Name
            };
            return customEntityRecordDto;
        }

        public async Task<CustomEntityGroupDto> GetTemplateByGroupId(int groupId)
        {
            var templateGroupInfo = await _customGroupRepository.FindAsync(x => x.Id == groupId);

            if (templateGroupInfo == null) return new CustomEntityGroupDto();

            return new CustomEntityGroupDto
            {
                Id = templateGroupInfo.Id,
                GroupName = templateGroupInfo.Name,
                CustomEntities = templateGroupInfo.CustomEntities.Select(x => new CustomEntityDto
                {
                    Id = x.Id,
                    TemplateName = x.TemplateName
                }).ToList()
            };
        }

        public async Task<IEnumerable<Core.Domain.CustomEntity.CustomEntity>> GetTemplates()
        {
            return await _customTemplateRepository.GetAllAsync();
        }

        public async Task<SaveResponseDto> UpdateTemplate(Core.Domain.CustomEntity.CustomEntity customEntity)
        {
            var res = await _customTemplateRepository.UpdateAsync(customEntity, customEntity.Id);
            return new SaveResponseDto
            {
                SaveSuccessful = res != null,
                SavedEntityId = customEntity.Id
            };
        }
        
    }
}