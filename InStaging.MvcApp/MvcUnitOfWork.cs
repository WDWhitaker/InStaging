using InStaging.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InStaging.MvcApp
{
    public class MvcUnitOfWork : IUnitOfWork
    {
        public MvcUnitOfWork()
        {
        }

        public IDataService DataService { get; set; }
    }
}
