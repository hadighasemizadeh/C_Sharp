using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDiffence
{
    class Tower
    {
        private readonly MapCellLocation location;

        public int shootPower { get; set; } = 1;
        public int shootRange { get; set; } = 1;
        public Tower(MapCellLocation _mapCellLocation)
        {
            location = _mapCellLocation;
        }



        private readonly static Random random = new Random();

        public void FireOnEnemy(Enemy[] enemies)
        {
            foreach (var enemy in enemies)
            {
                if (enemy.isActive && location.isInRangeOf(enemy.location, shootRange))
                {
                    enemy.DecreaseHealth(shootPower);
                    // Only hit one enemy at the time
                    break;
                }
            }
        }
    }
}
