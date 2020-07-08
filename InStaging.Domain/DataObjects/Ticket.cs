﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InStaging.Domain.DataObjects
{
    public class Ticket : Interfaces.IDataObject
    {
        public Guid Id { get; set; }
        public bool Archived { get; set; }

        public string Descriptions { get; set; }
        public string Title { get; set; }

        public Enums.TicketStatus Status { get; set; }
        public Enums.TicketType Type { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }


    }
}