using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proyecto_INGYSA_MVC_2021.Models.IRepository
{
    interface IDBRepository: IDisposable
    {
        IQueryable<T> GetAll<T>(bool noTracking = true) where T : class;
        T Add<T>(T entity) where T : class;
        T Delete<T>(T entity) where T : class;
        T Attach<T>(T entity) where T : class;
        T AttachIfNot<T>(T entity) where T : class;

        int Commit();
        Task<int> CommitAsync(CancellationToken cancellationToken = default(CancellationToken));
        T Execute<T>(string funtionName, params object[] parameters);
    }
}
