using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DepotEice.DAL.IRepositories
{
    internal interface IRepositoryBase<TEntity, TKey>
        where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetByKey(TKey key);
        TKey Create(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
    }
}
