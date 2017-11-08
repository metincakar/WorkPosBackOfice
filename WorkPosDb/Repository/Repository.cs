using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkPosDb.Repository
{
  public  class Repository<T>:IRepository<T>where T:class
    {
       private DbContext rdbcontext=null;

       public Repository(DbContext contex)
        {
            this.rdbcontext = contex;
        }
      public IEnumerable<T> GetAll()
      {
          return rdbcontext.Set<T>().ToList();
      }

      public IBindingList GetAll2()
       {
           rdbcontext.Set<T>().Load();
           return rdbcontext.Set<T>().Local.ToBindingList();
       }

      public void Insert(T entity)
      {
          rdbcontext.Set<T>().Add(entity);
          rdbcontext.SaveChanges();
      }

      public void Delete(T entity)
      {
          rdbcontext.Set<T>().Attach(entity);
          rdbcontext.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
          rdbcontext.SaveChanges();
      }

      public void Update(T entity)
      {
          rdbcontext.Set<T>().Attach(entity);
          rdbcontext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
          rdbcontext.SaveChanges();
          //Context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
      }

      public T GetById(object Id)
      {
          return rdbcontext.Set<T>().Find(Id);
      }

      public void DeleteById(object Id, T entity)
      {
          rdbcontext.Set<T>();
      }
    }
}
