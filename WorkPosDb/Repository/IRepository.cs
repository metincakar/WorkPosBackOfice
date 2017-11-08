using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkPosDb.Repository
{
    interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(object Id);
        void DeleteById(object Id, T entity);

    }
}
