using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Domain;
using SFX.Domain.Response;

namespace SFX.Services.Interfaces.Generic
{
    public interface IGenericService<T> where T: BaseEntity
    {
        Task<PagedResult<T>> GetAll(int page, int? pageSize);

        System.Threading.Tasks.Task DeleteAll(List<int> ids);

        System.Threading.Tasks.Task Delete(int id);

        Task<SaveResponseDto> Insert(T entity);

        Task<SaveResponseDto> Update(T entity);

        Task<T> GetById(int id);
    } 
}
