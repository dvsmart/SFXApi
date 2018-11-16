using System.Collections.Generic;
using System.Threading.Tasks;

using SFX.Core.Domain.CustomEntity;
using SFX.Core.Domain.Response;
using SFX.Core.Interfaces.Repositories;
using SFX.Core.Interfaces.ServicesCustomEntity;

namespace SFX.Services.CustomEntity
{
    public class TemplateFormControlService : ITemplateFormControlService
    {
        private readonly IGenericRepository<CustomField> _customFieldRepository;

        public TemplateFormControlService(IGenericRepository<CustomField> customFieldRepository)
        {
            _customFieldRepository = customFieldRepository;
        }

        public async Task<SaveResponseDto> Add(CustomField customField)
        {
            return new SaveResponseDto
            {
                SaveSuccessful = await _customFieldRepository.AddAsync(customField) != null,
                SavedEntityId = customField.Id
            };
        }

        public async Task<SaveResponseDto> DeleteAsync(int id)
        {
            var customField = await _customFieldRepository.FindAsync(x=>x.Id == id);
            return new SaveResponseDto
            {
                SaveSuccessful = await _customFieldRepository.DeleteAsync(customField) != default(int),
                SavedEntityId = customField.Id
            };
        }

        public async Task<IEnumerable<CustomField>> GetAll()
        {
            return await _customFieldRepository.GetAllAsync();
        }

        public async Task<IEnumerable<CustomField>> GetFieldsByTabId(int id)
        {
            return await _customFieldRepository.FindAllAsync(x=>x.CustomTabId == id);
        }

        public async Task<SaveResponseDto> UpdateAsync(CustomField customField)
        {
            return new SaveResponseDto
            {
                SaveSuccessful = await _customFieldRepository.UpdateAsync(customField,customField.Id) != null,
                SavedEntityId = customField.Id
            };
        }
    }
}
