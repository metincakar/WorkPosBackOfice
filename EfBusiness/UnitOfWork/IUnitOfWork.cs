using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfBusiness.UnitOfWork
{
    public  interface IUnitOfWork:IDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;
        int SaveChanges();
        // Başka operasyonlar da tanımlanabilir. 
        // void OpenTransaction(); 
        // void CloseTransaction(); 
        // gibi 
    }

    
}
