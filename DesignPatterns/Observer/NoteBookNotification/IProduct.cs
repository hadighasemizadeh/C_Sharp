using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    public interface IProduct
    {
        string  Name  { get; }
        decimal Price { get; }
        void Notify   ( decimal newPrice);

        void AddFollower(ICustomer customer);
        void RemoveFollower(ICustomer customer);
    }
}
