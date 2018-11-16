
using SFX.Core.Interfaces.Repositories;
using SFX.Core.Interfaces.ServicesSettings.CustomEntityManagement;
using System;
using System.Threading.Tasks;

namespace SFX.Services.Settings.CustomEntityManagement
{
    public sealed class CustomTemplateService : ICustomTemplateService
    {
        private readonly IGenericRepository<Core.Domain.CustomEntity.CustomEntity> _customTemplateRepository;

        public CustomTemplateService(IGenericRepository<Core.Domain.CustomEntity.CustomEntity> customTemplateRepository)
        {
            _customTemplateRepository = customTemplateRepository;
        }

        public async Task<CustomTemplateResponse> GetTemplateDetail(int id)
        {
            var template = await _customTemplateRepository.FindByIdAsync(id);
            return MapTemplateResponse(template);
        }

        public async Task<CustomTemplateResponse> CreateTemplate(
            CreateCustomTemplateRequest createCustomTemplateRequest)
        {
            var request = MapTemplateRequest(createCustomTemplateRequest);
            var response = await _customTemplateRepository.AddAsync(request);
            return MapTemplateResponse(response);
        }


        public async Task<CustomTemplateResponse> UpdateTemplate(
            CreateCustomTemplateRequest createCustomTemplateRequest)
        {
            var request = MapTemplateRequest(createCustomTemplateRequest);
            var response = await _customTemplateRepository.UpdateAsync(request,request.Id);
            return MapTemplateResponse(response);
        }

        private CustomTemplateResponse MapTemplateResponse(Core.Domain.CustomEntity.CustomEntity templateResponse)
        {
            if (templateResponse == null) return new CustomTemplateResponse();
            return new CustomTemplateResponse
            {
                Id = templateResponse.Id,
                Name = templateResponse.TemplateName,
                CategoryId = templateResponse.EntityGroupId.GetValueOrDefault(),
                CategoryName = templateResponse.EntityGroup?.Name,
                IsVisible = !templateResponse.IsArchived && !templateResponse.IsDeleted
            };
        }

        private Core.Domain.CustomEntity.CustomEntity MapTemplateRequest(CreateCustomTemplateRequest templateRequest)
        {
            return new Core.Domain.CustomEntity.CustomEntity
            {
                Id = templateRequest.Id,
                TemplateName = templateRequest.TemplateName,
                AddedBy = 1,
                ModifiedBy = templateRequest.Id == default(int) ? (int?) null : 1,
                ModifiedDate = templateRequest.Id == default(int) ? (DateTime?) null : DateTime.UtcNow,
                EntityGroupId = templateRequest.CategoryId == default(int) ? null : templateRequest.CategoryId,
                IsArchived = false,
                IsDeleted = false,
            };
        }
    }
}
