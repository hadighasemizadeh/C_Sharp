using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDiffence
{
    class Level
    {
        private readonly Enemy[] enemies;
        public Tower[] towers { get; set; }

        public Level(Enemy[] _enemies)
        {
            enemies = _enemies;
        }

        public bool play()
        {
            int remainingEnemies = enemies.Length;
            while (remainingEnemies > 0)
            {
                foreach (var tower in towers)
                {
                    tower.FireOnEnemy(enemies);
                }

                remainingEnemies = 0;
                foreach (var enemy in enemies)
                {
                    if (enemy.isActive)
                    {
                        enemy.Move();

                        if (enemy.conqueredTower)
                        {
                            // Game Over
                            return false;
                        }
                        remainingEnemies++;
                    }
                }
            }
            // Still have chance to win dude!!
            return true;
        }
    }
}
