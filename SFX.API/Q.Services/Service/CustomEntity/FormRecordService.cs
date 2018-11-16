using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFX.Core.Domain.CustomEntity;
using SFX.Core.Domain.Response;
using SFX.Dtos.CustomEntity;
using SFX.Infrastructure.IRepositories;
using SFX.Services.Interfaces.CustomEntity;

namespace SFX.Services.Service.CustomEntity
{
    public class FormRecordService : IFormRecordService
    {
        private readonly IFormRecordRepository _formRecordRepository;

        public FormRecordService(IFormRecordRepository formRecordRepository)
        {
            _formRecordRepository = formRecordRepository;
        }

        public async Task<SaveResponseDto> Add(CustomEntityInstance customEntityInstance)
        {
            try
            {
                var id = await _formRecordRepository.GetLastDataId();
                customEntityInstance.DataId = Helper.DataIdGenerationService.GenerateDataId(id, "CE");
                var response = await _formRecordRepository.Add(customEntityInstance);
                return new SaveResponseDto
                {
                    SaveSuccessful = response != null,
                    RecordId = customEntityInstance.Id,
                    SavedDataId = customEntityInstance.DataId,
                    SavedEntityId = customEntityInstance.CustomEntityId
                };
            }
            catch (Exception ex)
            {
                return new SaveResponseDto
                {
                    SaveSuccessful = false,
                    ErrorMessage = ex.Message,
                };
            }
        }

        public async Task<CustomEntityRecordDto> Get(int id)
        {
            var recordDto = await _formRecordRepository.Get(id);
            if (recordDto == null) return null;
            return recordDto;
        }

        public Task<CustomEntityRecordDto> GetByTemplateId(int templateId)
        {
            ar recordDto = await _formRecordRepository.Get(id);
            if (recordDto == null) return null;
            return recordDto;
        }
    }
}
