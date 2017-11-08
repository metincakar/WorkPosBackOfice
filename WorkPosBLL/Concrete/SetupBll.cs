using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using EfBusiness;
using EfBusiness.UnitOfWork;
using WorkPosBLL.Abstract;
using WorkPosDal.EntityFrameWork;


namespace WorkPosBLL.Concrete
{
    public  class SetupBll<T>:ISetupBll<T> where T:class 
    {
        private readonly WorkPosDbContext _context = new WorkPosDbContext();

        //readonly Repository<T> _repository=new Repository<T>(context); 

        private readonly Repository<T> _repository;//=new Repository<T>(context);
        private UnitOfWork _uow;

        public SetupBll()
        {
            _uow=new UnitOfWork(_context);
            _repository = new Repository<T>(_context);
        }
        public void Add(T entity)
        {
            _repository.Add(entity);
            _uow.SaveChanges();
        }

        public void Delete(T entity)
        {
           _repository.Delete(entity);
           _uow.SaveChanges();
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
            _uow.SaveChanges();
        }
        public List<T> GetAllList()
        {
            return _repository.GetAll().ToList();
        }
        public IBindingList GetAllToBindingList()
        {
            
            return _repository.GetAllToBindingList();
        }

       
        public int Save()
        {
           return _uow.SaveChanges();
        }
    }
}
