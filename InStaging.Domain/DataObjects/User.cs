using System;
using System.Collections.Generic;
using System.Text;

namespace InStaging.Domain.DataObjects
{
    public class User
    {
        public Guid Id { get; set; }
        public bool Archived { get; set; }

        public  ICollection<Comment> Comments { get; set; }

        public  ICollection<UserApplication> UserApplications { get; set; }
        public  ICollection<Ticket> AssignedTickets { get; set; }
    }
}
