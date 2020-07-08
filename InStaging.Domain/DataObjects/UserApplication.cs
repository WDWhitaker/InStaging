using System;
using System.Collections.Generic;
using System.Text;

namespace InStaging.Domain.DataObjects
{
    public class UserApplication
    {
        public Guid Id { get; set; }
        public bool Archived { get; set; }

        public Guid ApplicationId { get; set; }
        public virtual Application Application { get;set;}

        public Guid UserId { get; set; }
        public virtual User User { get; set; }

    }
}
