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

        public float accuracy { get; set; } = .6F;

        private readonly static Random random = new Random();

        public void FireOnEnemy(Enemy[] enemies)
        {
            foreach (var enemy in enemies)
            {
                if (enemy.isActive && location.isInRangeOf(enemy.location, shootRange))
                {
                    if (isSuccessfulShoot())
                    {
                        enemy.DecreaseHealth(shootPower);
                        Console.WriteLine("Nice shoot!");

                        // Hited enemy is dead or not
                        if (enemy.isDead)
                            Console.WriteLine("I sent him to the hell!");
                    }
                    else
                    {
                        Console.WriteLine("Damn, I missed the target!!");
                    }

                    // Only hit one enemy at the time
                    break;
                }
            }
        }

        // Check to see it was a successful shoot or not
        public bool isSuccessfulShoot()
        {
            return random.Next() >= accuracy;
        }
    }
}
