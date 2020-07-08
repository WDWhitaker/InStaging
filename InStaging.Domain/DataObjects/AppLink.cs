using System;
using System.Collections.Generic;
using System.Text;

namespace InStaging.Domain.DataObjects
{
    public class AppLink : Interfaces.IDataObject
    {
        public Guid Id { get; set; }
        public bool Archived { get; set; }

        public Guid AppId { get; set; }
        public string UrlString { get; set; }
        
        public virtual ICollection<AppLink> AppLinks { get; set; }


    }
}
