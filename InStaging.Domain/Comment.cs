using System;
using System.Collections.Generic;
using System.Text;

namespace InStaging.Domain
{
    public class Comment 
    {
        public Guid Id { get; set; }
        public bool Archived { get; set; }

        public Guid UserId { get; set; }
        public  User User { get; set; }

        public string Message { get; set; }

        public ICollection<CommentFile> CommentFiles { get; set; }

        public Guid TicketId { get; set; }
        public Ticket Ticket { get; set; }
    }
}
