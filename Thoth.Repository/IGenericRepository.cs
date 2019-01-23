using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thoth.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(int Id);
        void Delete(TEntity entity);
        TEntity GetByID(int id);
        IEnumerable<TEntity> GetAll();
        //void Dispose();

        //IEnumerable<TEntity> GetAll();
        //TEntity GetById(int Id);
        //void Insert(TEntity entity);
        //void Delete(int Id);
        //void Update(TEntity entity);
        //void Save();
    }
}
