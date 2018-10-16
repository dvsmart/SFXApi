using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Domain;
using SFX.Domain.CustomEntity;
using SFX.Services.Interfaces.CustomEntity;

namespace SFX.Services.Service.CustomEntity
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
