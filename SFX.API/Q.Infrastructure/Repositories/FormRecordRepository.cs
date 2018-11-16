using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SFX.Core.Domain.CustomEntity;
using SFX.Core.Domain.Response;
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


        Task<CustomEntityInstance> Get(int id)
        {
            throw new NotImplementedException();
        }

        Task<CustomEntityInstance> IFormRecordRepository.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
