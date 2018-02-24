using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDiffence
{
    class MapCellLocation:Cell
    {
        public MapCellLocation(int x, int y, Map map):base(x,y)
        {
            if (!map.OnMap(this))
            {
                throw new Exception(string.Format("Err: ({0},{1}) is out of boundry!",x,y));
            }
        }

        public bool isInRangeOf(MapCellLocation _location, int _range)
        {
            return DistanceFrom(_location) <= _range;
        }
    }
}
