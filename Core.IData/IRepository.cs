using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.IData
{
    public interface IRepository<TEntity, in TKey> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        TEntity Get(TKey id);
        IQueryable<TEntity> GetAll();
    }
}
