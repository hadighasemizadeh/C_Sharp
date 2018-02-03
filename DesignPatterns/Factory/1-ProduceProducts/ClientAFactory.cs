using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP
{
    class ClientAFactory : IFactory
    {
        public IComputer CreateComputer()
        {
            return new ClientAComputer();
        }

        public ITablet CreateTablet()
        {
            return new ClientATablet();
        }

        public ITv CreateTv()
        {
            return new ClientATv();
        }
    }
}
