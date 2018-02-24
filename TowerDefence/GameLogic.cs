using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDiffence
{
    class GameLogic
    {
        static void Main(string[] args)
        {
            Map map = new Map(8,5);

            try
            {
                Path path = new Path(
                new[]{
                new MapCellLocation(0,2,map),
                new MapCellLocation(1,2,map),
                new MapCellLocation(2,2,map),
                new MapCellLocation(3,2,map),
                new MapCellLocation(4,2,map),
                new MapCellLocation(5,2,map),
                new MapCellLocation(6,2,map),
                new MapCellLocation(7,2,map),
                });

                // Generate three towers
                Tower[] towers = new Tower[]
                {
                    new Tower(new MapCellLocation(0,3,map)),
                    new Tower(new MapCellLocation(2,3,map)),
                    new Tower(new MapCellLocation(4,3,map)),
                };

                // Generate three enemies
                Enemy[] enemies = new Enemy[]
                {
                    new Enemy(path),
                    new Enemy(path),
                    new Enemy(path),
                    new Enemy(path)
                };

                Level level1 = new Level(enemies);
            }
            catch (OutOfMap ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (GameException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
