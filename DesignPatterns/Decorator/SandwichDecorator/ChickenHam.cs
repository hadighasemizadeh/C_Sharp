using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    public class ChickenHam : Decorator
    {
        public ChickenHam(SandwichComponent sandwichComponent) : base(sandwichComponent)
        {
            _name = "ChickenHam";
            _price = 1.00m;
        }
    }
}
