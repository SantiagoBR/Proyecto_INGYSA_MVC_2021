using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Models.IRepository
{
    public class DBRepository : IDBRepository
    {
        protected DbContext DbContext;

        public DBRepository(DbContext dbContext)
        {
            this.DbContext = dbContext;
            ConfigureContext();

        }
        public DBRepository()
        {
            ConfigureContext();
        }
        protected virtual void ConfigureContext()
        {
            DbContext.Configuration.LazyLoadingEnabled = false;
        }
        public T Add<T>(T entity) where T : class
        {
            return GetDbset<T>().Add(entity);
        }
        private DbSet<T> GetDbset<T>() where T : class
        {
            return DbContext.Set<T>();
        }
        public virtual T Attach<T>(T entity) where T : class
        {
            return GetDbset<T>().Attach(entity);
        }
        public virtual T AttachIfNot<T>(T entity) where T : class
        {
            if (DbContext.Entry(entity).State == EntityState.Detached)
            {
                return Attach(entity);
            }
            return entity;
        }
        public virtual int Commit()
        {
            return DbContext.SaveChanges();
        }
        //ok

        public Task<int> CommitAsync(CancellationToken cancellationToken = default)
        {
            return DbContext.SaveChangesAsync(cancellationToken);
        }

        //ok
        public virtual T Delete<T>(T entity) where T : class
        {
            if (DbContext.Entry(entity).State == EntityState.Detached)
            {
                DbContext.Entry(entity).State = EntityState.Deleted;
                return entity;
            }
            else
            {
                return GetDbset<T>().Remove(entity);
            }
        }

        //ok
        public void Dispose()
        {
            DbContext.Dispose();
        }

        //OK
        public virtual T Execute<T>(string functionName, params object[] parameters)
        {
            MethodInfo method = DbContext.GetType().GetMethod(functionName);
            return (T)method.Invoke(DbContext, parameters);
        }

        //ok
        public virtual IQueryable<T> GetAll<T>(bool noTracking = true) where T : class
        {
            var entityDbSet = GetDbset<T>();
            if (noTracking)
            {
                return entityDbSet.AsNoTracking();
            }
            return entityDbSet;

        }

        public void Update<T>(T entity) where T : class
        {
            DbContext.Entry(entity).State = EntityState.Modified;
        }

        
    }
}