using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SFX.Domain.CustomEntity;
using SFX.Domain.Response;
using SFX.Infrastructure.Context;
using SFX.Infrastructure.IRepositories;

namespace SFX.Infrastructure.Repositories
{
    public class FormRecordRepository : IFormRecordRepository
    {
        private readonly AppDbContext _context;

        public FormRecordRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<SaveResponseDto> Add(CustomEntityInstance customEntityInstance)
        {

            var response = await  _context.CustomEntityInstances.AddAsync(customEntityInstance);
            await _context.SaveChangesAsync();
            return new SaveResponseDto
            {
                SaveSuccessful = response.Entity != null,
                RecordId = customEntityInstance.Id,
                SavedDataId = customEntityInstance.DataId,
                SavedEntityId = customEntityInstance.CustomEntityId
            };
        }


        public async Task<int> GetLastDataId()
        {
            var lastRecord =  await _context.CustomEntityInstances.LastAsync();
            return int.Parse(Regex.Replace(lastRecord.DataId, "[^0-9]",""));
        }

        public async Task<CustomEntityRecordDto> Get(int id)
        {
            var record = await (from cer in _context.CustomEntityInstances
                                where cer.Id == id
                                select new CustomEntityRecordDto
                                {
                                    Id = cer.Id,
                                    CustomEntityId = cer.CustomEntityId,
                                    DataId = cer.DataId,
                                    TemplateName = cer.CustomEntity.TemplateName,
                                    CustomTabs = cer.CustomEntity.CustomTabs.Select(x => new CustomTabDto
                                    {
                                        Id = x.Id,
                                        IsVisible = x.IsVisible,
                                        Caption = x.Name,
                                        IsOptional = x.IsOptional,
                                        CustomFields = x.CustomFields.Select(cf => new CustomFieldDto
                                        {
                                            FieldId = cf.Id,
                                            IsVisible = cf.IsVisible.GetValueOrDefault(),
                                            IsRequired = cf.IsMandatory.GetValueOrDefault(),
                                            Caption = cf.FieldName,
                                            Type = cf.FieldType.Caption,
                                            Value = cf.DefaultValue
                                        })
                                    })
                                }).FirstOrDefaultAsync();
            return record;
        }

    
    }
}
