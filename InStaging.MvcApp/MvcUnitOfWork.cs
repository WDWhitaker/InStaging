using InStaging.Domain.DTOs;
using InStaging.Domain.Interfaces;
using InStaging.SqlDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InStaging.MvcApp
{
    public class MvcUnitOfWork : IUnitOfWork
    {
        public MvcUnitOfWork(SqlDataContext context)
        {
            DataService = new SqlDataService.SqlDataService(context);
            AuthenticationToken = new AuthenticationToken();
        }

        public IDataService DataService { get; set; }
        public AuthenticationToken AuthenticationToken { get ; set; }
    }
}
