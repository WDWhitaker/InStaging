﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InStaging.Domain.DataObjects
{
    public class Application 
    {
        public Guid Id { get; set; }
        public bool Archived { get; set; }
        public string Name { get; set; }
    }
}
