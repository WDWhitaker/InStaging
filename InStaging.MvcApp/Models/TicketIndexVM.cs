﻿using InStaging.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InStaging.MvcApp.Models
{
    public class TicketIndexVM
    {
        public List<Ticket> ActiveTickets { get; internal set; }
    }
}
