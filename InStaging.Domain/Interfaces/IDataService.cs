using InStaging.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InStaging.Domain.Interfaces
{
    public interface IDataService : IDisposable
    {
        public IQueryable<Ticket> Tickets { get; }
        public int SaveChanges();
    }
}
