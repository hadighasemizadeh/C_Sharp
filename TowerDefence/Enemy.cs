using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDiffence
{
    class Enemy
    {
        private readonly Path path;
        private int pathStep = 0;

        public bool conqueredTower { get { return pathStep >= path.pathLength; } }
        public bool isDead { get { return enemyHealth <= 0; } }
        public bool isActive { get { return !(isDead || conqueredTower); } }


        public MapCellLocation location
        {
            get {return path.getLocationAt(pathStep); }
        }

        public int enemyHealth
        {
            get;
            private set;
        } = 2;

        public Enemy(Path _path)
        {
            path = _path;
        }

        public void Move()
        {
            pathStep++;
        }

        public void DecreaseHealth(int _pow)
        {
            enemyHealth -= _pow;
        }
    }
}
