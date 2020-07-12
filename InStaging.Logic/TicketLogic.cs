using InStaging.Domain;
using InStaging.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace InStaging.Logic
{
    public class TicketLogic : BaseLogic
    {
        public TicketLogic(IUnitOfWork uow) : base(uow)
        {

        }

        public List<Ticket> GetActiveTickets()
        {
            var model = Uow.DataService
                .Tickets
                .Where(a => a.Archived == false && a.Status <= Domain.Enums.TicketStatus.Complete)
                .Where(a => a.Status != Domain.Enums.TicketStatus.Complete)
                .Where(a => a.Status != Domain.Enums.TicketStatus.Backlog)
                .ToList();

            return model;
            //var tickets = Uow.DataService
        }
    }
}
