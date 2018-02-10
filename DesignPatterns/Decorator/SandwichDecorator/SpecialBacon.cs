using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    public class SpecialBacon : Decorator
    {
        public SpecialBacon(SandwichComponent sandwichComponent) : base(sandwichComponent)
        {
            _name = "Special Bacom";
            _price = 1.45m;
        }
    }
}
