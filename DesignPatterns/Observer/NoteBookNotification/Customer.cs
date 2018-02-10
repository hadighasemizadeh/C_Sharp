using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    public class Customer : ICustomer
    {
        public void Update(IProduct product)
        {
            Console.WriteLine("Dear customer, price of {0} changed to {1}", product.Name, product.Price);
        }
    }
}
