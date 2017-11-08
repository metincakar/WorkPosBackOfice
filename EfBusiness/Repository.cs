using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WorkPosDal.EntityFrameWork;

namespace EfBusiness{public class Repository<T> : IRepository<T>  where T : class {
       /* IObjectContextAdapter _context;

        IObjectSet<T> _objectSet;*/

        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

       // WorkPosDbContext  _dbContext=new WorkPosDbContext();

        public Repository(WorkPosDbContext dbContext)
        {

            // ObjectContext nesnesi oluşturyoruz.
            _dbContext = dbContext;

            _dbSet = dbContext.Set<T>();

        }

        #region IRepository Members
        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }
        public List<T> GetAllList()
        {
            return _dbSet.ToList();
        }
 
        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }
 
        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
 
        public T Get(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).SingleOrDefault();
        }
 
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }
 
        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
 
        public void Delete(T entity)
        {
            // Eğer sizlerde genelde bir kayıtı silmek yerine IsDelete şeklinde bool bir flag alanı tutuyorsanız,
            // Küçük bir refleciton kodu yardımı ile bunuda otomatikleştirebiliriz.
            if (entity.GetType().GetProperty("IsDelete") != null)
            {
                T _entity = entity;
 
                _entity.GetType().GetProperty("IsDelete").SetValue(_entity, true);
 
                this.Update(_entity);
            }
            else
            {
                // Önce entity'nin state'ini kontrol etmeliyiz.
                DbEntityEntry dbEntityEntry = _dbContext.Entry(entity);
 
                if (dbEntityEntry.State != EntityState.Deleted)
                {
                    dbEntityEntry.State = EntityState.Deleted;
                }
                else
                {
                    _dbSet.Attach(entity);
                    _dbSet.Remove(entity);
                }
            }
        }
 
        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity == null) return;
            else
            {
                if (entity.GetType().GetProperty("IsDelete") != null)
                {
                    T _entity = entity;
                    _entity.GetType().GetProperty("IsDelete").SetValue(_entity, true);
 
                    this.Update(_entity);
                }
                else
                {
                    Delete(entity);}
            }
        }

        public IBindingList GetAllToBindingList()
        {
           _dbSet.Load();
           return _dbSet.Local.ToBindingList();
        }

        #endregion

    }
}
