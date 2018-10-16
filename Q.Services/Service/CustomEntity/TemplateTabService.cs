using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SFX.Domain;
using SFX.Domain.CustomEntity;
using SFX.Domain.Response;
using SFX.Dtos.CustomEntity;
using SFX.Services.Interfaces.CustomEntity;

namespace SFX.Services.Service.CustomEntity
{
    public class TemplateTabService : ITemplateTabService
    {
        private readonly IGenericRepository<CustomTab> _customTabRepository;
        private readonly IGenericRepository<Domain.CustomEntity.CustomEntity> _customEntityRepository;


        public TemplateTabService(IGenericRepository<CustomTab> customTabRepository, IGenericRepository<Domain.CustomEntity.CustomEntity> customEntityRepository)
        {
            _customTabRepository = customTabRepository;
            _customEntityRepository = customEntityRepository;
        }

        public async Task<SaveResponseDto> Add(CustomTab customTab)
        {
            return new SaveResponseDto
            {
                SaveSuccessful = await _customTabRepository.AddAsync(customTab) != null,
                RecordId = customTab.Id
            };
        }

        public async Task<SaveResponseDto> Delete(int id)
        {
            var customTab = await _customTabRepository.FindAsync(x => x.Id == id);
            var response = await _customTabRepository.DeleteAsync(customTab);
            return new SaveResponseDto
            {
                SaveSuccessful = response != default(int),
                RecordId = customTab.Id
            };
        }

        public async Task<IEnumerable<CustomTab>> GetAll()
        {
            return await _customTabRepository.GetAllAsync();
        }

        public async Task<CustomTab> GetById(int id)
        {
            return await _customTabRepository.FindAsync(x=>x.Id == id);
        }

        public async Task<CustomTemplateTabDto> GetTabsById(int id)
        {
            var ce = await _customEntityRepository.FindAsync(x=>x.Id == id);
            var tabDto = new CustomTemplateTabDto();
            if (ce == null) return tabDto;

            if (ce.CustomTabs.Any())
            {
                tabDto.TemplateTabs = ce.CustomTabs?.Select(x => new CustomDto()
                {
                    Id = x.Id,
                    Caption = x.Name
                }).ToList();
            }
            return tabDto;
        }

        public async Task<SaveResponseDto> UpdateAsync(CustomTab customTab)
        {
            var response = await _customTabRepository.UpdateAsync(customTab, customTab.Id);
            return new SaveResponseDto
            {
                SaveSuccessful =  response != null,
                SavedEntityId = customTab.Id
            };
        }

    }
}
