using InStaging.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace InStaging.SqlDataService
{
    public class SqlDataRepository<T> : IDataRepository<T> where T : class
    {
        DbSet<T> dbset { get; set; }
        public SqlDataRepository(SqlDataContext db)
        {
            dbset = db.Set<T>();
        }
        public SqlDataRepository(DbSet<T> _dbset)
        {
            dbset = _dbset;
        }
        public void Add(T model)
        {
            dbset.Add(model);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            return dbset.Where(predicate);
        }
        public IQueryable<T> AsQueryable()
        {
            return dbset.AsQueryable();
        }
    }
}
