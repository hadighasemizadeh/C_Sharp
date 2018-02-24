using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDiffence
{
    public class Map
    {
        public readonly int width;
        public readonly int heigth;

        public Map(int _width, int _height)
        {
            width = _width;
            heigth = _height;
        }
        // Check to see if the cell is on map or not
        public bool OnMap(Cell cell)
        {
            bool cellIsOnMap = cell.X >= 0 && cell.X < width && cell.Y >= 0 && cell.Y < heigth;
            return cellIsOnMap;
        }
    }
}
