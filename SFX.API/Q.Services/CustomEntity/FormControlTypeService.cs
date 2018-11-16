using System.Collections.Generic;
using System.Threading.Tasks;

using SFX.Core.Domain.CustomEntity;
using SFX.Core.Interfaces.Repositories;
using SFX.Core.Interfaces.ServicesCustomEntity;

namespace SFX.Services.CustomEntity
{
    public class FormControlTypeService : IFormControlTypeService
    {
        private readonly IGenericRepository<CustomFieldType> _customFieldTypeRepository;

        public FormControlTypeService(IGenericRepository<CustomFieldType> customFieldTypeRepository)
        {
            _customFieldTypeRepository = customFieldTypeRepository;
        }

        public async Task<ICollection<CustomFieldType>> GetCustomFieldTypes()
        {
            return await _customFieldTypeRepository.GetAllAsync();
        }
    }
}
