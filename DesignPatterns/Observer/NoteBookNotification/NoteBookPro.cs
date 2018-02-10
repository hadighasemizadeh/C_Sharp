using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    class NoteBookPro : IProduct
    {
        private decimal _price;
        private readonly List<ICustomer> _customers = new List<ICustomer>();

        public string Name
        {
            get { return "NoteBookPro"; }
        }

        public NoteBookPro(decimal price)
        {
            _price = price;
        }

        public decimal Price
        {
            get { return _price; }
            set { Notify(value); }
        }

        public void Notify(decimal newPrice)
        {
            _price = newPrice;
            for (int i = 0; i < _customers.Count; i++)
            {
                _customers[i].Update(this);
            }
        }

        public void AddFollower(ICustomer customer)
        {
            _customers.Add(customer);
        }

        public void RemoveFollower(ICustomer customer)
        {
            _customers.Remove(customer);
        }
    }
}
