using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InStaging.MvcApp.Models
{
    public class TicketAddVM
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public Domain.Enums.TicketType Type { get; set; }
    }
}
