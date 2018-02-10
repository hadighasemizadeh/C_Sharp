using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    public class SpecilBaconDiscount : Decorator
    {
        public SpecilBaconDiscount(SandwichComponent sandwichComponent) : base(sandwichComponent)
        {
            _name = "Special Bacon Discount";
            _price = -0.70m;
        }
    }
}
