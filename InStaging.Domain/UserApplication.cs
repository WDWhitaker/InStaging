using System;
using System.Collections.Generic;
using System.Text;

namespace InStaging.Domain
{
    public class UserApplication
    {

        public Guid ApplicationId { get; set; }
        public  Application Application { get;set;}

        public Guid UserId { get; set; }
        public  User User { get; set; }

    }
}
