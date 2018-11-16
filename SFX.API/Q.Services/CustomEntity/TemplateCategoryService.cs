using System.Collections.Generic;
using System.Threading.Tasks;

using SFX.Core.Domain.CustomEntity;
using SFX.Core.Domain.Response;
using SFX.Core.Interfaces.Repositories;
using SFX.Core.Interfaces.ServicesCustomEntity;

namespace SFX.Services.CustomEntity
{
    public class TemplateCategoryService : ITemplateCategoryService
    {
        private readonly IGenericRepository<CustomEntityGroup> _customEntityGroupRepository;

        public TemplateCategoryService(IGenericRepository<CustomEntityGroup> customEntityGroupRepository)
        {
            _customEntityGroupRepository = customEntityGroupRepository;
        }
        public async Task<SaveResponseDto> AddGroup(CustomEntityGroup customEntityGroup)
        {
            var res = await _customEntityGroupRepository.AddAsync(customEntityGroup);
            return new SaveResponseDto
            {
                SaveSuccessful = res != null,
                SavedEntityId = customEntityGroup.Id
            };
        }

        public async Task<SaveResponseDto> DeleteGroup(int id)
        {
            var ceGroup = await _customEntityGroupRepository.FindAsync(x => x.Id == id);
            var response = await _customEntityGroupRepository.DeleteAsync(ceGroup);
            return new SaveResponseDto
            {
                SavedEntityId = id,
                SaveSuccessful = response != default(int)
            };
        }

        public async Task<CustomEntityGroup> GetGroupById(int id)
        {
            return await _customEntityGroupRepository.FindAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<CustomEntityGroup>> GetGroups()
        {
            return await _customEntityGroupRepository.GetAllAsync();
        }


        public async Task<SaveResponseDto> UpdateGroup(CustomEntityGroup customEntityGroup)
        {
            var res = await _customEntityGroupRepository.UpdateAsync(customEntityGroup, customEntityGroup.Id);
            return new SaveResponseDto
            {
                SaveSuccessful = res != null,
                SavedEntityId = customEntityGroup.Id
            };
        }
    }
}
