using SFX.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SFX.Core.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : IBaseEntity
    {
        T Add(T t);
        Task<T> AddAsync(T t);
        Task<int> CountAsync();
        void Delete(T entity);
        Task<int> DeleteAsync(T entity);

        Task<bool> DeleteAllAsync(List<T> entities);
        void Dispose();
        T Find(Expression<Func<T, bool>> match);
        ICollection<T> FindAll(Expression<Func<T, bool>> match);
        Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match);
        Task<T> FindAsync(Expression<Func<T, bool>> match);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        Task<ICollection<T>> FindByAsync(Expression<Func<T, bool>> predicate);
        T Get(int id);
        IQueryable<T> GetAll();
        Task<ICollection<T>> GetAllAsync();
        IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetAsync(int id);
        void Save();
        T Update(T entity, object key);
        Task<T> UpdateAsync(T entity, object key);

        Task<PagedResult<T>> GetPagedList(int page = 1, int? pageSize = 10);

        Task<PagedResult<T>> FilterList(Expression<Func<T, bool>> predicate, int page = 1, int? pageSize = 10);

        Task<int> GetLast();

        Task<T> FindByIdAsync(int id);
    }
}
