using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SFX.Domain;
using SFX.Domain.CustomEntity;
using SFX.Domain.Response;
using SFX.Services.Interfaces.CustomEntity;

namespace SFX.Services.Service.CustomEntity
{
    public class TemplateFormValueService : ITemplateFormValueService
    {
        private readonly IGenericRepository<CustomFieldValue> _customFieldValueRepository;

        public TemplateFormValueService(IGenericRepository<CustomFieldValue> customFieldValueRepository)
        {
            _customFieldValueRepository = customFieldValueRepository;
        }

        public async Task<SaveResponseDto> Add(List<CustomFieldValue> customFieldValues)
        {
            bool response = false;
            var existingFieldValues = _customFieldValueRepository.FindBy(x => x.CustomEntityRecordId == customFieldValues.FirstOrDefault().CustomEntityRecordId);
            if (existingFieldValues.Any())
            {
                foreach (var item in existingFieldValues)
                {
                    if(customFieldValues.Any(x => x.CustomFieldId == item.CustomFieldId))
                    {
                        foreach (var field in customFieldValues.Where(x => x.CustomFieldId == item.CustomFieldId))
                        {
                            item.Value = field.Value;
                        }
                        response = await _customFieldValueRepository.UpdateAsync(item, item.Id) != null;
                    }
                    else
                    {
                        foreach (var newItem in customFieldValues.Where(x=>x.CustomFieldId == item.CustomFieldId))
                        {
                            response = await _customFieldValueRepository.AddAsync(newItem) != null;
                        }
                    }
                }
            }
            foreach (var item in customFieldValues)
            {
                response = await _customFieldValueRepository.AddAsync(item) != null;
            }

            return new SaveResponseDto
            {
                SaveSuccessful = response
            };
        }
    }
}
