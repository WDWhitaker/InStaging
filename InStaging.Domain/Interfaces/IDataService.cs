using InStaging.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InStaging.Domain.Interfaces
{
    public interface IDataService : IDisposable
    {
        public IDataRepository<Ticket> Tickets { get; }
        public IDataRepository<Application> Applications { get; }
        public int SaveChanges();
    }
}
