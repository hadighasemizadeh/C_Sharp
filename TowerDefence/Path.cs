using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDiffence
{
    class Path
    {
        private readonly MapCellLocation[] path;
        public int pathLength { get { return path.Length; } }
        public Path(MapCellLocation[] _path)
        {
            path = _path;
        }

        public MapCellLocation getLocationAt(int pathStep)
        {
            return (pathStep <= path.Length)?path[pathStep] : null;
        }
    }
}
