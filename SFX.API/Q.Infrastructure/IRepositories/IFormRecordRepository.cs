using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SFX.Domain.CustomEntity;
using SFX.Domain.Response;
using SFX.Dtos.CustomEntity;

namespace SFX.Infrastructure.IRepositories
{
    public interface IFormRecordRepository
    {
        Task<CustomEntityRecordDto> Get(int id);

        Task<SaveResponseDto> Add(CustomEntityInstance customEntityInstance);

        Task<int> GetLastDataId();
       
    }
}
