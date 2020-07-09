using InStaging.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InStaging.Logic
{
    public abstract class BaseLogic
    {
        internal IUnitOfWork Uow { get; set; }
        public BaseLogic(IUnitOfWork uow)
        {
            Uow = uow;
        }
    }
}
