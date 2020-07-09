using System;
using System.Collections.Generic;
using System.Text;

namespace InStaging.Domain
{
    public class Application 
    {
        public Guid Id { get; set; }
        public bool Archived { get; set; }
        public string Name { get; set; }
        public ICollection<UserApplication> UserApplications { get; set; }
    }
}
