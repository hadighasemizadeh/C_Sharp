﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    public interface ICustomer
    {
        void Update(IProduct product);
    }
}
