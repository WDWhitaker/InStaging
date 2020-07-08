using System;
using System.Collections.Generic;
using System.Text;

namespace InStaging.Domain.Interfaces
{
    public interface IDataObject
    {
        public Guid Id { get; set; }
        public bool Archived { get; set; }
    }
}
