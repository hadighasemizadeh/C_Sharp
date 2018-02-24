using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDiffence
{
    public class Cell
    {
        public readonly int X;
        public readonly int Y;

        public Cell(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }

        // Cardisian formua to calculate distance from onther cell x,y
        public float DistanceFrom(int x, int y)
        {
            float dist = (float) Math.Sqrt(Math.Pow((X - x),2) + Math.Pow((Y - y),2));
            return dist;
        }

        // Cardisian formua to calculate distance from onther cell
        public float DistanceFrom(Cell cell)
        {
            return DistanceFrom(cell.X, cell.Y);
        }

    }
}
