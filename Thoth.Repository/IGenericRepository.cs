using System.Collections.Generic;

namespace Thoth.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(long Id);
        void Delete(TEntity entity);
        TEntity GetByID(long? id);
        IEnumerable<TEntity> GetAll();
    }
}
