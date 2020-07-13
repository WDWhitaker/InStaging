using System;
using System.Collections.Generic;
using System.Text;

namespace InStaging.Domain
{
    public class Ticket 
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Archived { get; set; }

        public string Description { get; set; }
        public string Title { get; set; }

        public Enums.TicketStatus Status { get; set; }
        public Enums.TicketType Type { get; set; }

        public  ICollection<Comment> Comments { get; set; }


        public Guid? AssignedUserId { get; set; }
        public User AssignedUser { get; set; }


    }
}
