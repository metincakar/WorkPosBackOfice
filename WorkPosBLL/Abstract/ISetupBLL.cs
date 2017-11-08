using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WorkPosBLL.Abstract
{
    public interface ISetupBll<T>
    {
        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);

        List<T> GetAllList();

        int Save();

    }

}
