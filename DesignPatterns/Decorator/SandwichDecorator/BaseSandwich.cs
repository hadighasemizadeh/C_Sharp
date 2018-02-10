﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    public class BaseSandwich : SandwichComponent
    {
        private string  _name = "Base Sandwich";
        private decimal _price = 1.00m;
        public override string Name
        {
            get { return _name; }
        } 

        public override decimal Price
        {
            get { return _price; }
        }
    }
}
