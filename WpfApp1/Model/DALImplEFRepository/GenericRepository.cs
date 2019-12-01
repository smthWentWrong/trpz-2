using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model.Entities.Model.Context;

namespace WpfApp1.Model.Entities.Model.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        protected MainContext _mainContext;
        
        public GenericRepository(MainContext dbContext)
        {
            _mainContext = dbContext;
        }

        public void Add(T entity)
        {
            _mainContext.Set<T>().Add(entity);
            _mainContext.SaveChanges();

        }
        public void Delete(T entity)
        {
            _mainContext.Set<T>().Remove(entity);
            _mainContext.SaveChanges();

        }
        public void Edit(T entity)
        {
            _mainContext.Entry(entity).State = EntityState.Modified;
        }
        public T GetById(int id)
        {
            return _mainContext.Set<T>().Find(id);
        }
        public List<T> List()
        {
            return _mainContext.Set<T>().ToList();
        }
        public List<T> List(Expression<Func<T, bool>> predicate)
        {
            return _mainContext.Set<T>().Where(predicate).ToList();
        }
    }

}
