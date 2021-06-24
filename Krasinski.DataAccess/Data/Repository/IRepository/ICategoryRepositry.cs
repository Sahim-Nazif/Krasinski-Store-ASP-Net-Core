using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Krasinski.DataAccess.Data.Repository.IRepository
{
    public interface ICategoryRepositry<T> where T: class
    {
        T Get(int id);

        IEnumerable<T> GetAll(

                Expression<Func<T, bool>> filter=null,
                Func<IQueryable <T>, IOrderedQueryable<T>> orderBy=null,
                string includeProperties=null

            );

        T GetFirstOrDefault(
             Expression<Func<T, bool>> filter = null,
              string includeProperties = null
            );

        public void Add(T entity);
        public void Remove(int id);
        public void Remove(T entity);

    }
}
