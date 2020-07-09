using InStaging.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace InStaging.Logic
{
    public class TicketLogic : BaseLogic
    {
        public TicketLogic(IUnitOfWork uow) : base(uow)
        {

        }

        public void GetActiveTickets()
        {
            //var tickets = Uow.DataService
        }
    }
}
