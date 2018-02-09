using System.Collections.Generic;

namespace FactoryDP
{
    internal class NewTechCompany
    {
        private readonly IFactory factory;
        private readonly List<IComputer> _computers;
        private readonly List<ITablet>   _tablets;
        private readonly List<ITv>       _tvs;

        // Get list data without being able to add to it out of this class
        public IEnumerable<IComputer> Comuters { get { return _computers.ToArray(); } }

        // Get list data without being able to add to it out of this class
        public IEnumerable<ITablet> Tablets { get { return _tablets.ToArray(); } }

        // Get list data without being able to add to it out of this class
        public IEnumerable<ITv> Tvs { get { return _tvs.ToArray(); } }

        public NewTechCompany(IFactory mFactory)
        {
            this.factory = mFactory;

            // Initialize list of products
            _computers  = new List<IComputer>();
            _tablets    = new List<ITablet>();
            _tvs        = new List<ITv>();
        }

        public void Produce(OrderProduct order) {
            // Create computer
            CreateComputers(order.Computers);
            // Create tablet
            CreateTablets(order.Tablets);
            // Create Tv
            CreateTvs(order.Tvs);

        }

        private void CreateComputers(int count) {
            while (_computers.Count < count) {
                _computers.Add(factory.CreateComputer());
            }
        }

        private void CreateTablets(int count)
        {
            while (_tablets.Count < count)
            {
                _tablets.Add(factory.CreateTablet());
            }
        }

        private void CreateTvs(int count)
        {
            while (_tvs.Count < count)
            {
                _tvs.Add(factory.CreateTv());
            }
        }
    }
}