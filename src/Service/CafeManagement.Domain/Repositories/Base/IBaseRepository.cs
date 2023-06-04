using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeManagement.Domain.Repositories.Base
{
    public interface IBaseRepository<TEntity, TKey>
    {
        Task CreateAsync(List<TEntity> entites);
        Task<TEntity> CreateAsync(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> FindAsync(TKey entityId);
        IQueryable<TEntity> Query();
    }
}