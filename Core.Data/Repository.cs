using Core.IData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class
    {
        private readonly DbContext dbContext;
        private readonly IDbSet<TEntity> dbSet;
        public Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            dbSet = dbContext.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            dbSet.Add(entity);
            dbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            dbSet.Remove(entity);
            dbContext.SaveChanges();
        }

        public TEntity Get(TKey id)
        {
            return dbSet.Find(id);
        }
        public IQueryable<TEntity> GetAll()
        {
            return dbSet;
        }
    }
}
