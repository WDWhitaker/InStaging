using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InStaging.Domain.Interfaces;

namespace InStaging.MvcApp.Controllers
{
    public abstract class BaseController : Controller
    {
        internal IUnitOfWork Uow { get; set; }
        public BaseController(IUnitOfWork uow)
        {
            Uow = new MvcUnitOfWork();
        }
    }
}
