using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDP
{
    public abstract class CompositeComponent : Component
    {
        public readonly List<Component> _componentList = new List<Component>();
        protected CompositeComponent(string name, int price) : base(name, price) { }

        public override void Add(Component component)
        {
            if (component is Computer)
            {
                throw new Exception("It should not be added.");
            }

            _componentList.Add(component);

        }

        public override int Price
        {
            get
            {
                var total = _price;
                foreach (var compon in _componentList)
                {
                    total += compon.Price;
                }
                                    
                return total;
            }
        }
    }
}
