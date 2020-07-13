using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace InStaging.Domain.Interfaces
{
    public interface IDataRepository<T> where T:class
    {
        public IQueryable<T> Where(Expression<Func<T, bool>> predicate);
        public IQueryable<T> AsQueryable();
        public void Add(T model);
    }
}
