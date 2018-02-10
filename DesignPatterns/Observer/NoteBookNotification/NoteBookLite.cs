using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    public class NoteBookLite : IProduct
    {
        private decimal _price;
        private delegate void priceProduct(IProduct product);
        private event priceProduct OnPriceUpdate;
        public NoteBookLite(decimal price)
        {
            _price = price;
        }
        public string Name
        {
            get { return "NoteBookLite"; }
        }

        public decimal Price
        {
            get { return _price; }
            set { Notify(value); }
        }

        public void Notify(decimal newPrice)
        {
            _price = newPrice;
            if (OnPriceUpdate != null)
            {
                OnPriceUpdate(this);
            }
        }

        public void AddFollower(ICustomer customer)
        {
            OnPriceUpdate += customer.Update;
        }

        public void RemoveFollower(ICustomer customer)
        {
          OnPriceUpdate -= customer.Update;
        }
    }
}
