﻿using InStaging.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InStaging.Logic
{
    public class ChangeRequestLogic : BaseLogic
    {
        public ChangeRequestLogic(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
