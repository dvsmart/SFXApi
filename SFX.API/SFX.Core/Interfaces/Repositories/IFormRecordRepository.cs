using SFX.Core.Domain.CustomEntity;
using SFX.Core.Domain.Response;
using System.Threading.Tasks;


namespace SFX.Infrastructure.IRepositories
{
    public interface IFormRecordRepository
    {
        Task<CustomEntityInstance> Get(int id);

        Task<SaveResponseDto> Add(CustomEntityInstance customEntityInstance);

        Task<int> GetLastDataId();
       
    }
}
