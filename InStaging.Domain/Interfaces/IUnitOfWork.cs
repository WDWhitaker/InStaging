﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InStaging.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        public IDataService DataService { get; set; }
    }
}
