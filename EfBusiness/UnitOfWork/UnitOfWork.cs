using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using WorkPosDal.EntityFrameWork;

namespace EfBusiness.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
       private readonly WorkPosDbContext _dbContext;
 
        public UnitOfWork(WorkPosDbContext dbContext)
        {
            Database.SetInitializer<WorkPosDbContext>(null);
 
            if (dbContext == null)
                throw new ArgumentNullException("dbContext can not be null.");
 
            _dbContext = dbContext;
 
            // Buradan istediğiniz gibi EntityFramework'ü konfigure edebilirsiniz.
            //_dbContext.Configuration.LazyLoadingEnabled = false;
            //_dbContext.Configuration.ValidateOnSaveEnabled = false;
            //_dbContext.Configuration.ProxyCreationEnabled = false;
        }
 
        #region IUnitOfWork Members
        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(_dbContext);
        }
 
        public int SaveChanges()
        {
          /*  try
            {
                // Transaction işlemleri burada ele alınabilir veya Identity Map kurumsal tasarım kalıbı kullanılarak
                // sadece değişen alanları güncellemeyide sağlayabiliriz.
                return _dbContext.SaveChanges();


            }
            catch
            {
                // Burada DbEntityValidationException hatalarını handle edebiliriz.
                throw;
            }*/

            using (var scope = new TransactionScope(TransactionScopeOption.Required,
    new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
            {
                // Do something 
                _dbContext.SaveChanges();
                // Do something else
                //context.SaveChanges();

                scope.Complete();
            }
            return 1;
        }
        #endregion
 
        #region IDisposable Members
        // Burada IUnitOfWork arayüzüne implemente ettiğimiz IDisposable arayüzünün Dispose Patternini implemente ediyoruz.
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
 
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
