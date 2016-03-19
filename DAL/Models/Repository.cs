using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Models
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }


        TEntity IRepository<TEntity>.Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        IEnumerable<TEntity> IRepository<TEntity>.GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        IEnumerable<TEntity> IRepository<TEntity>.Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate).ToList();
        }

        void IRepository<TEntity>.Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        void IRepository<TEntity>.Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }
    }
}
