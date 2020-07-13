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
        public IDataRepository<Ticket> Tickets { get => new SqlDataRepository<Ticket>(db); }
        public IDataRepository<Application> Applications { get => new SqlDataRepository<Application>(db); }


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
