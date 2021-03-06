﻿using InStaging.Domain;
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
                .Where(a => a.Archived == false)
                .Where(a => a.Status != Domain.Enums.TicketStatus.Complete)
                .ToList();

            return model;
        }

        public void CreateTicket(Ticket ticket)
        {
            try
            {
                Uow.DataService.Tickets.Add(ticket);
                Uow.DataService.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
    }
}
