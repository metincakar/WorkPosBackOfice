using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfBusiness;
using EfBusiness.UnitOfWork;
using WorkPosBLL.Abstract;
using WorkPosDal.EntityFrameWork;

namespace WorkPosBLL.Concrete
{
    public class MoneyBll: IMoneyBll
    {
        private readonly WorkPosDbContext _context = new WorkPosDbContext();

        //readonly Repository<T> _repository=new Repository<T>(context); 

        private readonly Repository<SETUP_MONEY> _repository;//=new Repository<T>(context);
        private UnitOfWork _uow;

         public MoneyBll()
         {
            _uow=new UnitOfWork(_context);
            _repository = new Repository<SETUP_MONEY>(_context);
         }


         public IEnumerable GetMoneyIEnumerable()
        {
            var query = (from c in _repository.GetAllList()
                         select new
                         {
                             MoneyId=c.MONEY_ID,
                             Money=c.MONEY
                         }
                );
            return query.ToList();
        }
    }
}
