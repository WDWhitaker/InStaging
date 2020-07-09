using InStaging.Domain;
using InStaging.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InStaging.SqlDataService
{
    public class SqlDataService : IDataService
    {
        private SqlDataContext db { get; set; }
        public SqlDataService(SqlDataContext dbContext)
        {
            db = dbContext;
        }
        public IQueryable<Ticket> Tickets { get => db.Ticket.AsQueryable(); }


        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
